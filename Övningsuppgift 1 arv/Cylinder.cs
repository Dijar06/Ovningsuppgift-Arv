using Arv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Cylinder : IShape
    {
        private double radie;
        private double height;

        public Cylinder(double radie, double height)
        {
            this.radie = radie;
            this.height = height;
        }

        public double Area()
        {
            return 2 * Math.PI * radie * height;
        }

        public double Circumferance()
        {
            return ((radie + radie) * 2) + (height * 2);
        }
    }
}
