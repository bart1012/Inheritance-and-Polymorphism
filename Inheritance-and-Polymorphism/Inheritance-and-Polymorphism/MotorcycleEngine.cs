﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    internal class MotorcycleEngine : Engine
    {
        public MotorcycleEngine(int horsepower, FuelType fuelType) : base(horsepower, fuelType)
        {
        }
    }
}
