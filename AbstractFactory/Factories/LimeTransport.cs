using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    public class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Scooter();
        }
    }
}
