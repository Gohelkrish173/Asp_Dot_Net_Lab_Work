using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_3
{
    internal class SBI : RBI
    {
        public double CalculateInterest(double Amount, double Year)
        {
            return ((Amount * 4 * Year) / 100);
        }
    }   
}
