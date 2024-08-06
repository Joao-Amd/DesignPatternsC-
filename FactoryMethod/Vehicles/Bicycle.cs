using System;

namespace FactoryMethod.Vehicles
{
    public class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda Uber eats!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a entrega.");
        }
    }
}
