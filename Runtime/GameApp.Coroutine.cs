using GameFrameX.Runtime;
#if ENABLE_GAME_FRAME_X_COROUTINE
using GameFrameX.Coroutine.Runtime;
#endif

public static partial class GameApp
{
#if ENABLE_GAME_FRAME_X_COROUTINE
    /// <summary>
    /// 获取协程组件。
    /// </summary>
    public static CoroutineComponent Coroutine
    {
        get
        {
            if (_coroutine == null)
            {
                _coroutine = GameEntry.GetComponent<CoroutineComponent>();
            }

            return _coroutine;
        }
    }

    private static CoroutineComponent _coroutine;
#endif
}