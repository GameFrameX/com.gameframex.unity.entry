using GameFrameX.Runtime;
using GameFrameX.Timer.Runtime;
using NUnit.Framework;

namespace GameFrameX.Entry.Tests
{
    /// <summary>
    /// GameApp 访问器会话一致性测试：Shutdown / 会话重置后，GameApp 静态访问器必须与
    /// GameFrameworkEntry.GetModule 路径行为一致——重新解析模块实例，而不是返回上一会话已关闭的缓存。
    /// 会话建立复刻自动注入启动的注册-实例化序列（扫描 → 注册映射 → 全量实例化），不创建场景对象。
    /// </summary>
    [TestFixture]
    public class GameAppAccessorSessionTests
    {
        [SetUp]
        public void SetUp()
        {
            GameFrameworkEntry.Shutdown();
            GameFrameXRuntimeHost.Reset();
            GameFrameworkLog.SetLogHelper(null);
        }

        [TearDown]
        public void TearDown()
        {
            GameFrameworkEntry.Shutdown();
            GameFrameXRuntimeHost.Reset();
            GameFrameworkLog.SetLogHelper(null);
        }

        [Test]
        public void GameApp_Accessor_ReturnsFreshInstance_AfterShutdown()
        {
            StartFrameworkSession();

            var first = GameApp.Timer;
            Assert.IsNotNull(first, "会话建立后 GameApp.Timer 应可解析 TimerManager");

            GameFrameworkEntry.Shutdown();

            // Restart 场景：Shutdown 后重建会话（映射随会话清空，重新扫描注册）。
            StartFrameworkSession();

            var second = GameApp.Timer;
            Assert.IsNotNull(second, "会话重建后 GameApp.Timer 应重新解析而不是返回 null");
            Assert.AreNotSame(first, second,
                "Shutdown 后 GameApp.Timer 仍返回上一会话的缓存实例（接口静态缓存失效，双入口行为不一致）");
            Assert.AreEqual(GameFrameworkEntry.GetModule<ITimerManager>(), second,
                "重新解析后 GameApp.Timer 应与 GetModule 路径返回同一实例");
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
