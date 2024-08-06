using System;

namespace AbstractFactory.Landvehicles
{
    public class Car : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros, estamos proston!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto.");
        }
    }
}
