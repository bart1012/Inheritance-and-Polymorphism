using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    internal abstract class Engine
    {
        internal bool Running { get; private set; } = false;
        internal int Horsepower { get; init; }

        internal FuelType FuelType { get; init; }

        internal Engine(int horsepower, FuelType fuelType)
        {
            Horsepower = horsepower;
            FuelType = fuelType;
        }

        internal void Start()
        {
            if (!Running)
            {
                Running = true;
            }
            else
            {
                Console.WriteLine("Engine already running!");
            }
            
        }
    }
}
