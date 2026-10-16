using System.Reflection;
using GameFrameX.Runtime;
using GameFrameX.Timer.Runtime;
using NUnit.Framework;
using UnityEngine;

namespace GameFrameX.Entry.Tests
{
    /// <summary>
    /// GameApp 访问器会话一致性测试：Shutdown / 会话重置后，GameApp 静态访问器（GameEntry.GetComponent 路径）
    /// 必须重新解析组件实例——静态字段依赖 Unity fake-null 失效，组件注册表清空后不返回上一会话已销毁的缓存。
    /// 会话建立复刻自动注入启动的注册-实例化序列（扫描 → 注册映射 → 全量实例化）；
    /// EditMode 下 AddComponent 不触发 Awake，反射驱动还原运行时行为，不依赖 Play 模式。
    /// </summary>
    [TestFixture]
    public class GameAppAccessorSessionTests
    {
        private GameObject m_GameObject;

        [SetUp]
        public void SetUp()
        {
            CleanSession();
        }

        [TearDown]
        public void TearDown()
        {
            if (m_GameObject != null)
            {
                Object.DestroyImmediate(m_GameObject);
                m_GameObject = null;
            }

            CleanSession();
        }

        [Test]
        public void GameApp_Accessor_ReturnsFreshInstance_AfterShutdown()
        {
            var first = CreateTimerComponent("Timer Session First");
            Assert.AreSame(first, GameApp.Timer, "会话建立后 GameApp.Timer 应命中已注册的 TimerComponent");

            // Restart 场景：清空组件注册表与模块实例，销毁宿主对象使静态缓存失效（fake-null）。
            GameEntry.Shutdown(ShutdownType.None);
            GameFrameworkEntry.Shutdown();
            Object.DestroyImmediate(m_GameObject);
            m_GameObject = null;

            Assert.IsNull(GameApp.Timer, "组件注册表清空后 GameApp.Timer 不应返回上一会话的缓存");

            // 会话重建（映射随会话清空，重新扫描注册），组件重新注册。
            var second = CreateTimerComponent("Timer Session Second");

            var resolved = GameApp.Timer;
            Assert.IsNotNull(resolved, "会话重建后 GameApp.Timer 应重新解析而不是返回 null");
            Assert.AreSame(second, resolved, "重新解析后 GameApp.Timer 应命中新注册的 TimerComponent");
            Assert.AreNotSame(first, resolved, "Shutdown 后 GameApp.Timer 仍返回上一会话的缓存实例");
        }

        private static void CleanSession()
        {
            GameEntry.Shutdown(ShutdownType.None);
            GameFrameworkEntry.Shutdown();
            GameFrameXRuntimeHost.Reset();
            GameFrameXRuntimeManagerResolver.Reset();
            GameFrameworkLog.SetLogHelper(null);
        }

        private TimerComponent CreateTimerComponent(string name)
        {
            StartFrameworkSession();

            m_GameObject = new GameObject(name);
            var component = m_GameObject.AddComponent<TimerComponent>();

            // EditMode 下 AddComponent 不触发 Awake，反射驱动还原运行时行为
            var awakeMethod = component.GetType().GetMethod("Awake", BindingFlags.Instance | BindingFlags.NonPublic);
            Assert.IsNotNull(awakeMethod, "组件应具有 Awake 生命周期方法");
            awakeMethod.Invoke(component, null);

            return component;
        }

        /// <summary>
        /// 复刻自动注入启动的模块注册序列（扫描 → 注册解析器与映射 → 全量实例化），不创建场景对象。
        /// </summary>
        private static void StartFrameworkSession()
        {
            var scanResult = GameFrameXRuntimeScanner.Scan();
            GameFrameXRuntimeManagerResolver.RegisterDescriptors(scanResult.ManagerDescriptors);
            foreach (var descriptor in scanResult.ManagerDescriptors)
            {
                GameFrameworkEntry.RegisterModule(descriptor.InterfaceType, descriptor.ImplementationType);
            }

            GameFrameworkEntry.InstantiateAllModules();
        }
    }
}
