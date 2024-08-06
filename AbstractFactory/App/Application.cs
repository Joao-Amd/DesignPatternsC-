using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.App
{
    public class Application
    {
        private IAircraft aircraft;
        private ILandvehicle vehicle;

        public Application(ITransportFactory factory)
        {
            aircraft = factory.CreateTransportAircraft();
            vehicle = factory.CreateTransportVehicle();           
        }

        public void StarRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
