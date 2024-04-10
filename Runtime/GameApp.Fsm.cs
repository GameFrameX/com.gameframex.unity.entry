using GameFrameX.Runtime;
#if ENABLE_GAME_FRAME_X_FSM
using GameFrameX.Fsm.Runtime;
#endif

public static partial class GameApp
{
#if ENABLE_GAME_FRAME_X_FSM
    /// <summary>
    /// 获取有限状态机组件。
    /// </summary>
    public static FsmComponent Fsm
    {
        get
        {
            if (_fsm == null)
            {
                _fsm = GameEntry.GetComponent<FsmComponent>();
            }

            return _fsm;
        }
    }

    private static FsmComponent _fsm;
#endif
}