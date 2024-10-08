﻿using Arv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Triangle : IShape
    {
        private double width;
        private double height;

        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return (width * height) / 2;
        }

        public double Circumferance()
        {
            double hypotenuse = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            return (width + height + hypotenuse);
        }
    }
}
