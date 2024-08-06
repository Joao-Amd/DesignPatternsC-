using Estrutural.Bridge.Platforms;
using System;

namespace Estrutural.Bridge.Transmissions
{
    public class Live : ITransmisson
    {
        private IPlatform _platform;

        public Live(IPlatform platform)
        {
            _platform = platform;
        }
        public void Broadcasting()
        {
            Console.WriteLine($"Inciando a transmissão na {_platform}");
        }

        public void Result()
        {
            Console.WriteLine("**** ON AIR ****");
        }
    }
}
