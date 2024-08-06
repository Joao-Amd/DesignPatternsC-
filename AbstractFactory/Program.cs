using AbstractFactory.App;
using AbstractFactory.Factories;
using System;
using System.Reflection;
using System.Runtime.Hosting;

namespace AbstractFactory
{
    public class Program
    {
        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;
            string company = "Lime";

            if (company == "Uber")
            {
                transportFactory = new UberTransport();
            }
            else if(company == "99")
            {
                transportFactory = new NineNineTransport();
            }
            else
            {
                transportFactory = new LimeTransport();
            }

            app = new Application(transportFactory);

            return app; 
        }
        static void Main(string[] args)
        {
            var app = ConfigureApplication();

            app.StarRoute();

            Console.ReadLine();
        }
    }
}
