using Arv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Sphere : IShape
    {
        private double radie;
        public Sphere(double radie)
        {
            this.radie = radie;
        }

        public double Area()
        {
            return 4 * Math.PI * (radie * radie);
        }

        public double Circumferance()
        {
            return 2 * Math.PI * radie;
        }
    }
}
