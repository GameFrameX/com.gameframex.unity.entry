#if ENABLE_GAME_FRAME_X_APPLE_LOGIN
using GameFrameX.Login.Apple.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取 AppleLogin 组件。
    /// </summary>
    public static AppleLoginComponent AppleLogin
    {
        get
        {
            if (_appleLogin == null)
            {
                _appleLogin = GameEntry.GetComponent<AppleLoginComponent>();
            }

            return _appleLogin;
        }
    }

    private static AppleLoginComponent _appleLogin;
}
#endif