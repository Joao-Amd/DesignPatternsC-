namespace Adpter.PayPals
{
    public interface IPayPalPayment
    {
        Token AuthToken();
        void PayPalPayment();
        void PayPalReceive();
    }
}
