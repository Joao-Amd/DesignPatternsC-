using System;

namespace AbstractFactory.Landvehicles
{
    public class Motorcycle : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
