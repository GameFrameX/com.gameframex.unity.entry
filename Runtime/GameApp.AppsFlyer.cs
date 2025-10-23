#if ENABLE_GAME_FRAME_X_APPSFLYER
using GameFrameX.AppsFlyer.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取 AppsFlyer 组件。
    /// </summary>
    public static AppsFlyerComponent AppsFlyer
    {
        get
        {
            if (_appsFlyer == null)
            {
                _appsFlyer = GameEntry.GetComponent<AppsFlyerComponent>();
            }

            return _appsFlyer;
        }
    }

    private static AppsFlyerComponent _appsFlyer;
}
#endif