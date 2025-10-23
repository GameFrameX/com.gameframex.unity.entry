#if ENABLE_GAME_FRAME_X_GOOGLE_LOGIN
using GameFrameX.Login.Google.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取 GoogleLogin 组件。
    /// </summary>
    public static GoogleLoginComponent GoogleLogin
    {
        get
        {
            if (_googleLogin == null)
            {
                _googleLogin = GameEntry.GetComponent<GoogleLoginComponent>();
            }

            return _googleLogin;
        }
    }

    private static GoogleLoginComponent _googleLogin;
}
#endif