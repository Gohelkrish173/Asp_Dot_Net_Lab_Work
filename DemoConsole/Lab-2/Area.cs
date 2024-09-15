using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_2
{
    interface Shape
    {
        public double Circle(double radius);
        public double Triangle(double h,double b);
        public double Square(double h);
    }
    internal class Area : Shape
    {
        double h, b, r;

        public double Circle(double radius)
        {
            this.r = radius;
            return Math.PI * r * r;
        }

        public double Triangle(double h,double b)
        {
            this.h = h;
            this.b = b;

            return ((.5) * h * b);
        }

        public double Square(double h)
        {
            this.h = h;
            return (h * h);
        }
    }
}
