#if ENABLE_GAME_FRAME_X_L_UGUI
using GameFrameX.Runtime;
using GameFrameX.LUGUI.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取UI组件。
    /// </summary>
    public static UGUIComponent GUI
    {
        get
        {
            if (_gui == null)
            {
                _gui = GameEntry.GetComponent<UGUIComponent>();
            }

            return _gui;
        }
    }

    private static UGUIComponent _gui;
}
#endif