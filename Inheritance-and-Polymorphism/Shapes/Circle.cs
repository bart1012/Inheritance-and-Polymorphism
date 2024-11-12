using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; init; } = 0;
        public int test { get; set; }
        public static readonly double PI = 3.14159;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return (Math.Pow(Radius, 2) * PI);
        }
    }
}
