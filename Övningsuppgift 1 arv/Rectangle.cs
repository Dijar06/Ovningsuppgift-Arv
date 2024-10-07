﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        { 
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return width * height;
        }

        public double Circumferance()
        {
            return 2 * (width + height);
        }
    }
}
