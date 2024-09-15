using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_3
{
    internal class CalArea
    {
        public double area(double x , double y)
        {
            return x * y;
        }
        public double area(double x)
        {
            return x * x;
        }
        public double area(int x)
        {
            return (3.14 * x*x);
        }
    }
}
