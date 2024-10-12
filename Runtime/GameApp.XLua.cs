#if ENABLE_GAME_FRAME_X_X_LUA
using GameFrameX.XLua.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取XLua组件。
    /// </summary>
    public static XLuaComponent XLua
    {
        get
        {
            if (_xlua == null)
            {
                _xlua = GameEntry.GetComponent<XLuaComponent>();
            }

            return _xlua;
        }
    }

    private static XLuaComponent _xlua;
}
#endif