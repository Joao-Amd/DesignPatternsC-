using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    public interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();
        void SetEngine(Engine engine);
        void SetSeats(int seats);
        void SetTransmission(Transmission transmission);
        void SetVehicleType(VehicleType vehicleType);
        void SetAirbag(bool airbag);
    }
}
