using GameFrameX.Runtime;
#if ENABLE_GAME_FRAME_X_PROCEDURE
using GameFrameX.Procedure.Runtime;
#endif

public static partial class GameApp
{
#if ENABLE_GAME_FRAME_X_PROCEDURE
    /// <summary>
    /// 获取流程组件。
    /// </summary>
    public static ProcedureComponent Procedure
    {
        get
        {
            if (_procedure == null)
            {
                _procedure = GameEntry.GetComponent<ProcedureComponent>();
            }

            return _procedure;
        }
    }

    private static ProcedureComponent _procedure;
#endif
}