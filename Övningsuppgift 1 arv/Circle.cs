using Arv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Circle : IShape
    {
        private double radie;

        public Circle(double radie)
        {
            this.radie = radie;
        }

        public double Area()
        {
            return (radie * radie) * Math.PI;
        }

        public double Circumferance()
        {
            return radie * Math.PI * 2;
        }
    }
}
