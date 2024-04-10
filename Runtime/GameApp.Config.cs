#if ENABLE_GAME_FRAME_X_CONFIG
using GameFrameX.Config.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取配置组件。
    /// </summary>
    public static ConfigComponent Config
    {
        get
        {
            if (_config == null)
            {
                _config = GameEntry.GetComponent<ConfigComponent>();
            }

            return _config;
        }
    }

    private static ConfigComponent _config;
}
#endif