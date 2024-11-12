using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    internal abstract class Vehicle
    {
        protected string Make { get; init; }
        protected string Model { get; init; }
        protected int Speed { get; set; }
        protected Engine EngineType { get; set; }



        internal Vehicle(string make, string model)
        {
            Make = make ?? throw new ArgumentNullException(nameof(make));
            Model = model ?? throw new ArgumentNullException(nameof(model));
        }

        internal Vehicle(string make, string model, Engine engineType)
        {
            Make = make ?? throw new ArgumentNullException(nameof(make));
            Model = model ?? throw new ArgumentNullException(nameof(model));
            EngineType = engineType ?? throw new ArgumentNullException(nameof(engineType));
        }

        internal void StartEngine()
        {
            EngineType.Start();
        }

        internal void Drive()
        {
            if (this.EngineType.Running)
            {
                this.Accelerate();
            }
            else
            {
                Console.WriteLine($"{Make} {Model} is not running.");
            }
        }

        protected abstract void Accelerate();
    }
}
