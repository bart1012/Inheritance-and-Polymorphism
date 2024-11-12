using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Pyramid : Shape3D
    {
        public double Height { get; init; }

        public Pyramid(double height, double baseLength) : base(new Triangle(baseLength, height))
        {
               
            Height = height;
        
        }

        public Pyramid(Triangle triangleShape, double height) : base(triangleShape) { Height = height; }

        public override double CalculateVolume()
        {
            return (BaseShape.CalculateArea() * Height) / 3;
        }
    }
}
