#if ENABLE_GAME_FRAME_X_FACEBOOK_LOGIN
using GameFrameX.Login.FaceBook.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取 FaceBookLogin 组件。
    /// </summary>
    public static FaceBookLoginComponent FaceBookLogin
    {
        get
        {
            if (_faceBookLogin == null)
            {
                _faceBookLogin = GameEntry.GetComponent<FaceBookLoginComponent>();
            }

            return _faceBookLogin;
        }
    }


    private static FaceBookLoginComponent _faceBookLogin;
}
#endif