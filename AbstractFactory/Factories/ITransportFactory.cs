using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    public interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        ILandvehicle CreateTransportVehicle();
    }
}
