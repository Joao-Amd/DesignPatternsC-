using System;

namespace Estrutural.Bridge.Platforms
{
    public class TwitchTV : IPlatform
    {
        public TwitchTV()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTV: Transmissão Iniciada.");
        }
        public void AuthToken()
        {
            Console.WriteLine("TwitchTV: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTV: Configurando servidor RMTP.");
        }

    }
}
