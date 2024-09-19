using Arv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height) { }

        public override double Area()
        {
            return (width * height) / 2;
        }

        public override double Circumferance()
        {
            double hypotenuse = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            return (width + height + hypotenuse);
        }
    }
}
