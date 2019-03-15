
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return this.radius * radius * Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return this.radius * Math.PI * 2;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
