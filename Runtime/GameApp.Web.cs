using GameFrameX.Runtime;
#if ENABLE_GAME_FRAME_X_WEB
using GameFrameX.Web.Runtime;
#endif

public static partial class GameApp
{
#if ENABLE_GAME_FRAME_X_WEB
    /// <summary>
    /// 获取Web组件。
    /// </summary>
    public static WebComponent Web
    {
        get
        {
            if (_web == null)
            {
                _web = GameEntry.GetComponent<WebComponent>();
            }

            return _web;
        }
    }

    private static WebComponent _web;
#endif
}