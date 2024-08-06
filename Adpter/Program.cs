using Adpter.MercadoPagos;
using Adpter.Payonners;
using Adpter.PayPals;
using System;

namespace Adpter
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Sem adpter
            //var payment = new PayPal();
            //payment.PayPalPayment();
            //payment.PayPalReceive();

            //Com adpter na utilização do Paynnoer
            //--------------------------------
            //var payment = new PayonnerAdpter(new Payonner());

            //payment.PayPalPayment();
            //payment.PayPalReceive();

            //Console.ReadLine();

            //--------------------------------
            //Com adpter na utilização do Mercado pago

            var payment = new MercadoPagoAdpter(new MercadoPago());

            payment.PayPalPayment();
            payment.PayPalReceive();

            Console.ReadLine();
        }
    }
}
