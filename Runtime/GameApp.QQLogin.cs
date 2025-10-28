#if ENABLE_GAME_FRAME_X_QQ_LOGIN
using GameFrameX.Login.QQ.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取 QQLogin 组件。
    /// </summary>
    public static QQLoginComponent QQLogin
    {
        get
        {
            if (_qqLogin == null)
            {
                _qqLogin = GameEntry.GetComponent<QQLoginComponent>();
            }

            return _qqLogin;
        }
    }

    private static QQLoginComponent _qqLogin;
}
#endif