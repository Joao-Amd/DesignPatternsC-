using FactoryMethod.Factories;
using System;

namespace FactoryMethod
{
     class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null;

            if(args.Length > 0 && args[0] == "--uber")
            {
                var teste = new CarTransport();
                teste.Teste();

            } else if (args.Length > 0 && args[0] == "--log")
            {
                transport = new MotorcycleTransport();
            }
            else if (args.Length > 0 && args[0] == "--eats")
            {
                transport = new BicycleTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo de serviço.");
            }

            if (transport != null)
                transport.StartTransport();

            Console.ReadLine();
        }
    }
}
