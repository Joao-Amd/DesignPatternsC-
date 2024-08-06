using System;
using Estrutural.Bridge.Platforms;
using Estrutural.Bridge.Transmissions;

namespace Estrutural.Bridge
{
    public class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();

        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Recording();
            live.Result();
        }


        static void Main(string[] args)
        {
            StartLive(new YouTube());
            StartLive(new Facebook());
            StartLiveAdvanced(new TwitchTV());
            StartLiveAdvanced(new DLive());

            Console.ReadLine();
        }
    }
}
