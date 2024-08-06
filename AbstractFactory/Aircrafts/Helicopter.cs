using System;

namespace AbstractFactory.Aircrafts
{
    public class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verifiacando os ventos, ventos  sudeste, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok. Ligando as helices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem...");
        }
    }
}
