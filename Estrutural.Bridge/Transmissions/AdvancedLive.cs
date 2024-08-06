using Estrutural.Bridge.Platforms;
using System;

namespace Estrutural.Bridge.Transmissions
{
    public class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform): base(platform) { }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão!");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados na live.");
        }

        public void Recording()
        {
            Console.WriteLine("Gravações liberadas na live.");
        }

    }
}
