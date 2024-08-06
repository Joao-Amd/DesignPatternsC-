using Adpter.PayPals;
using System;

namespace Adpter.Payonners
{
    public class Payonner : IPayonnerPaymente
    {
        private Token _token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivaPayment()
        {
            _token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Payonner.");
        }

        public void SendPayment()
        {
            _token = AuthToken();
            Console.WriteLine("Enviando pagamento com Payonner.");
        }
    }
}
