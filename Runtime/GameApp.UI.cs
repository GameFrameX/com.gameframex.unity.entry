#if ENABLE_GAME_FRAME_X_UI
using GameFrameX.UI.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取UI组件。
    /// </summary>
    public static UIComponent UI
    {
        get
        {
            if (_ui == null)
            {
                _ui = GameEntry.GetComponent<UIComponent>();
            }

            return _ui;
        }
    }

    private static UIComponent _ui;
}
#endif