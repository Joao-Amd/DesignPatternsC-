using Adpter.PayPals;

namespace Adpter.Payonners
{
    public interface IPayonnerPaymente
    {
        Token AuthToken();
        void SendPayment();
        void ReceivaPayment();
    }
}
