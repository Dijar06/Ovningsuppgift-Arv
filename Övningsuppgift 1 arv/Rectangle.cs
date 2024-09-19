using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height) { }

        public override double Area()
        {
            return width * height;
        }

        public override double Circumferance()
        {
            return 2 * (width + height);
        }
    }
}
