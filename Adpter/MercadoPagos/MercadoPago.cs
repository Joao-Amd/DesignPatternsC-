using Adpter.PayPals;
using System;

namespace Adpter.MercadoPagos
{
    public class MercadoPago : IMercadoPagoPayment
    {
        private Token _token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivaMercadoPago()
        {
            _token = AuthToken();
            Console.WriteLine("Recebendo pagamento com MercadoPago.");
        }

        public void SendMercadoPago()
        {
            _token = AuthToken();
            Console.WriteLine("Enviando pagamento com MercadoPago.");
        }
    }
}
