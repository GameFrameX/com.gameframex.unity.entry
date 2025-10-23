#if ENABLE_GAME_FRAME_X_PAYMENT
using GameFrameX.Payment.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取 Payment 组件。
    /// </summary>
    public static PaymentComponent Payment
    {
        get
        {
            if (_payment == null)
            {
                _payment = GameEntry.GetComponent<PaymentComponent>();
            }

            return _payment;
        }
    }

    private static PaymentComponent _payment;
}
#endif