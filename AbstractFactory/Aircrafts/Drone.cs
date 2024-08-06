using System;

namespace AbstractFactory.Aircrafts
{
    public class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verifiacando os ventos, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Controle ok. Ligando as helices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem...");
        }
    }
}
