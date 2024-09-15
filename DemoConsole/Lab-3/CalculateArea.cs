using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_3
{
    internal class CalculateArea
    {
        public double Area(double h,double b)
        {
            return (.5 * h * b);
        }

        public double Area(double h)
        {
            return (h * h);
        }
    }
}
