using System;

namespace Estrutural.Bridge.Platforms
{
    public class DLive : IPlatform
    {
        public DLive()
        {
            ConfigureRMTP();
            Console.WriteLine("DLive: Transmissão Iniciada.");
        }
        public void AuthToken()
        {
            Console.WriteLine("DLive: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("DLive: Configurando servidor RMTP.");
        }

    }
}
