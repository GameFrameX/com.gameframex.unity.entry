using GameFrameX.Runtime;
#if ENABLE_GAME_FRAME_X_MONO
using GameFrameX.Mono.Runtime;
#endif

public static partial class GameApp
{
#if ENABLE_GAME_FRAME_X_MONO
    /// <summary>
    /// 获取Mono组件。
    /// </summary>
    public static MonoComponent Mono
    {
        get
        {
            if (_mono == null)
            {
                _mono = GameEntry.GetComponent<MonoComponent>();
            }

            return _mono;
        }
    }

    private static MonoComponent _mono;
#endif
}