using Adpter.PayPals;
using System;
using System.Runtime.InteropServices;

namespace Adpter.MercadoPagos
{
    public class MercadoPagoAdpter : IPayPalPayment
    {
        private MercadoPago _mercadoPago;
        public MercadoPagoAdpter(MercadoPago mercadoPago)
        {
            _mercadoPago = mercadoPago;
            Console.WriteLine("Realizando Adaptação de Payoneer para os métodos do Mercado pago");
        }
        public Token AuthToken()
        {
            return _mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
             _mercadoPago.SendMercadoPago();
        }

        public void PayPalReceive()
        {
            _mercadoPago.ReceivaMercadoPago();
        }
    }
}
