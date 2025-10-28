#if ENABLE_GAME_FRAME_X_WECHAT_LOGIN
using GameFrameX.Login.WeChat.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取 WeChatLogin 组件。
    /// </summary>
    public static WeChatLoginComponent WeChatLogin
    {
        get
        {
            if (_weChatLogin == null)
            {
                _weChatLogin = GameEntry.GetComponent<WeChatLoginComponent>();
            }

            return _weChatLogin;
        }
    }

    private static WeChatLoginComponent _weChatLogin;
}
#endif