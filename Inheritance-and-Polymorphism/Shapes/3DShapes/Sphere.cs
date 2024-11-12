using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Sphere : Shape3D
    {


        public Sphere( double radius) : base(new Circle(radius)) { }
        public Sphere(Circle circleShape) : base(circleShape) { }

        public override double CalculateVolume()
        {
            double radius = Math.Sqrt(BaseShape.CalculateArea() / Circle.PI);
            return (Circle.PI * Math.Pow(radius, 3)) *  (4.0 / 3.0);
        }
    }
}
