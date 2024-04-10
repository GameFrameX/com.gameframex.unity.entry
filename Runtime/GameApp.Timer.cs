using GameFrameX.Runtime;
#if ENABLE_GAME_FRAME_X_TIMER
using GameFrameX.Timer.Runtime;
#endif

public static partial class GameApp
{
#if ENABLE_GAME_FRAME_X_TIMER
    /// <summary>
    /// 获取定时器组件。
    /// </summary>
    public static TimerComponent Timer
    {
        get
        {
            if (_timer == null)
            {
                _timer = GameEntry.GetComponent<TimerComponent>();
            }

            return _timer;
        }
    }

    private static TimerComponent _timer;
#endif
}