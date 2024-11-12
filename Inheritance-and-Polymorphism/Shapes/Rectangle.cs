using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public double Width { get; init; }
        public double Length { get; init; }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override double CalculateArea()
        {
            return Width * Length;
        }
    }
}
