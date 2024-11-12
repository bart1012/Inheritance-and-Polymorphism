using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Prism : Shape3D
    {
        public double Height { get; init; }

        public Prism(double height, double baseLength) : base(new Triangle(baseLength, height))
        {
            Height = height;
        }

        public Prism(Triangle traingleShape, double height) : base(traingleShape) { Height = height; }

        public override double CalculateVolume()
        {
            return BaseShape.CalculateArea() * Height;
        }
    }
}
