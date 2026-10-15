// ==========================================================================================
//  GameFrameX 组织及其衍生项目的版权、商标、专利及其他相关权利
//  GameFrameX organization and its derivative projects' copyrights, trademarks, patents and other related rights
//  均受中华人民共和国及相关国际法律法规保护。
//  are protected by the laws of the People's Republic of China and applicable international regulations.
//
//  使用本项目须严格遵守相应法律法规与开源许可证之规定。
//  Usage of this project must strictly comply with applicable laws, regulations and open-source licenses.
//
//  本项目采用 MIT 许可证与 Apache License 2.0 双许可证分发，
//  完整许可证文本请参见源代码根目录下的 LICENSE 文件。
//  please refer to the LICENSE file at the root directory of the source code for the full license text.
//
//  禁止利用本项目实施任何危害国家安全、破坏社会秩序、
//  It is prohibited to use this project to engage in any activities that endanger national security, disrupt social order,
//  侵犯他人合法权益等法律法规所禁止的行为！
//  or to infringe upon any legal rights or interests of others as prohibited by laws and regulations.
//
//  因基于本代码库二次开发所产生的一切法律纠纷与责任，
//  Any legal disputes or liabilities arising from secondary development based on this code base,
//  本组织与贡献者概不承担。
//  shall be borne solely by the developer; the organization and contributors assume no responsibility.
//
//  GitHub 仓库：https://github.com/GameFrameX
//  GitHub Repository:  https://github.com/GameFrameX
//  Gitee  仓库：https://gitee.com/GameFrameX
//  Gitee Repository:  https://gitee.com/GameFrameX
//  CNB  仓库：https://cnb.cool/GameFrameX
//  CNB Repository:  https://cnb.cool/GameFrameX
//  官方文档：https://gameframex.doc.alianblank.com/
//  Official documentation:  https://gameframex.doc.alianblank.com/
// ==========================================================================================

using GameFrameX.Runtime;

/// <summary>
/// GameApp 模块访问器缓存：按模块类型缓存 <see cref="GameFrameworkEntry.GetModule{T}"/> 结果，
/// 并以 <see cref="GameFrameworkEntry.SessionVersion"/> 检测会话重建（<c>Shutdown</c> 后模块实例集被清空），
/// 自动重新解析——接口引用没有 Unity fake-null 自愈能力，必须显式校验会话版本，
/// 保证 GameApp 静态入口与 GetModule 路径在 Restart / 关闭 Domain Reload 场景下行为一致。
/// </summary>
internal static class GameAppModuleCache<TModule> where TModule : class
{
    private static TModule s_Instance;

    private static int s_SessionVersion;

    /// <summary>
    /// 获取模块实例；会话版本变化时重新解析。
    /// </summary>
    /// <returns>模块实例</returns>
    public static TModule Get()
    {
        if (s_Instance == null || s_SessionVersion != GameFrameworkEntry.SessionVersion)
        {
            s_Instance = GameFrameworkEntry.GetModule<TModule>();
            s_SessionVersion = GameFrameworkEntry.SessionVersion;
        }

        return s_Instance;
    }
}
