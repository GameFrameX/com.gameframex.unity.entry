using GameFrameX.Runtime;
#if ENABLE_GAME_FRAME_X_SETTING
using GameFrameX.Setting.Runtime;
#endif

public static partial class GameApp
{
#if ENABLE_GAME_FRAME_X_SETTING
    /// <summary>
    /// 获取配置组件。
    /// </summary>
    public static SettingComponent Setting
    {
        get
        {
            if (_setting)
            {
                _setting = GameEntry.GetComponent<SettingComponent>();
            }

            return _setting;
        }
    }

    private static SettingComponent _setting;
#endif
}