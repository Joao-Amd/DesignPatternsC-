using Adpter.PayPals;

namespace Adpter.MercadoPagos
{
    public interface IMercadoPagoPayment
    {
        Token AuthToken();
        void SendMercadoPago();
        void ReceivaMercadoPago();

    }
}
