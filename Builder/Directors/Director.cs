using Builder.Builders;
using Builder.Components;

namespace Builder.Directors
{
    public class Director
    {
        IBuilder Builder;

        public Director(IBuilder builder)
        {
            Builder = builder;
        }

        public void ConstructSedanCar()
        {
            Builder.SetVehicleType(VehicleType.SEDAN);
            Builder.SetEngine(new Engine(2000));
            Builder.SetSeats(5);
            Builder.SetTransmission(Transmission.AUTOMATIC);
            Builder.SetAirbag(false);
        }

        public void ConstructTruck()
        {
            Builder.SetVehicleType(VehicleType.TRUCK);
            Builder.SetEngine(new Engine(4000));
            Builder.SetSeats(2);
            Builder.SetTransmission(Transmission.MANUAL);
            Builder.SetAirbag(false);
        }

        public void ConstructSuv()
        {
            Builder.SetVehicleType(VehicleType.SUV);
            Builder.SetEngine(new Engine(2600));
            Builder.SetSeats(5);
            Builder.SetTransmission(Transmission.AUTOMATIC);
            Builder.SetAirbag(true);
        }
    }
}
