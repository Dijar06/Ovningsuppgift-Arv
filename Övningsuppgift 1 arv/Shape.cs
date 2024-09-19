using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Shape
    {
        protected double width;
        protected double height;

        public Shape(double w, double h)
        {
            width = w;
            height = h;
        }

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Circumferance()
        {
            return 0;
        }
    }
}
