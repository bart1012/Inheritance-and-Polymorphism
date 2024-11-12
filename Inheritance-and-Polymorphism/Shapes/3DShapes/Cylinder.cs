using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cylinder : Shape3D
    {

        public double Height { get; init; }

        public Cylinder(double height, double radius) : base(new Circle(radius))
        {
            Height = height;
        }

        public Cylinder(Circle circleShape, double height) : base(circleShape) {
            Height = height;
        }

        public override double CalculateVolume()
        {
            return this.BaseShape.CalculateArea() * Height;
        }
    }
}
