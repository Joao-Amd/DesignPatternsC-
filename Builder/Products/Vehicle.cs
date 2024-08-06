using Builder.Components;
using System.Reflection;

namespace Builder.Products
{
    public class Vehicle
    {
        public VehicleType VehicleType { get; set; }
        public int Seats { get; set; }
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public bool Airbag { get; set; }
    }
}
