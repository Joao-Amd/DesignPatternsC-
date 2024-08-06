using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            VehivleBuilder builder = new VehivleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();

            Vehicle sedan = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {sedan.VehicleType}");

            director.ConstructTruck();

            Vehicle truck = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {truck.VehicleType}");

            director.ConstructSuv();

            Vehicle suv = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {suv.VehicleType}");

            Console.ReadLine();

        }
    }
}
