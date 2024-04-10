using GameFrameX.Runtime;
#if ENABLE_GAME_FRAME_X_GLOBAL_CONFIG
using GameFrameX.GlobalConfig.Runtime;
#endif

public static partial class GameApp
{
#if ENABLE_GAME_FRAME_X_GLOBAL_CONFIG
    /// <summary>
    /// 获取全局配置组件。
    /// </summary>
    public static GlobalConfigComponent GlobalConfig
    {
        get
        {
            if (_globalConfig == null)
            {
                _globalConfig = GameEntry.GetComponent<GlobalConfigComponent>();
            }

            return _globalConfig;
        }
    }

    private static GlobalConfigComponent _globalConfig;
#endif
}