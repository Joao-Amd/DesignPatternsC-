using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    public class Scooter : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda com a Lime.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
