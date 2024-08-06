using System;

namespace Estrutural.Bridge.Platforms
{
    public class Facebook : IPlatform
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmissão iniciada.");
        }
        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando servidor RMTP.");
        }
    }
}
