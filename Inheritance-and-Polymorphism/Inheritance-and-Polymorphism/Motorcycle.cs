using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Inheritance_and_Polymorphism
{
    internal class Motorcycle : Vehicle
    {
        internal bool HasSideCar { get; private set; }

        internal Motorcycle(string make, string model, bool hasSideCar, int horsePower, FuelType fuelType) : base(make, model, new MotorcycleEngine(horsePower, fuelType))
        {
            
            HasSideCar = hasSideCar;
        }

        protected override void Accelerate()
        {
            string message = $"{Make} {Model} speed: ";
            double fuelMod = EngineType.FuelType switch
            {
                FuelType.Unleaded => 1.5D,
                FuelType.Leaded => 1.2D,
                FuelType.Diesel => 1.8D,
                _ => throw new InvalidOperationException($"Unexpected value: {EngineType.FuelType}")
            };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{message}{((EngineType.Horsepower * fuelMod) * Math.Exp(Math.Sqrt(i)) / 2) * (HasSideCar ? 0.8 : 1.0)}mph");
            }
        } 
    }
}
