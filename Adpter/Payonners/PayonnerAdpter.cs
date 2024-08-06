using System;
using Adpter.PayPals;

namespace Adpter.Payonners
{
    public class PayonnerAdpter : IPayPalPayment
    {
        private Payonner _payonner;

        public PayonnerAdpter(Payonner payonner)
        {
            _payonner = payonner;
            Console.WriteLine("Realizando Adaptação de Payoneer para os métodos do PayPal");
        }

        public Token AuthToken()
        {
            return _payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            _payonner.SendPayment();
        }

        public void PayPalReceive()
        {
            _payonner.ReceivaPayment();
        }
    }
}
