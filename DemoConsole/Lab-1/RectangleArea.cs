using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_1
{
    internal class RectangleArea
    {
        double l;
        double h;
        double ans;
        public RectangleArea(double l,double h) 
        {
            ans = l * h;
        }

        public void DisplayArea()
        {
            Console.WriteLine(ans);
        }
    }
}
