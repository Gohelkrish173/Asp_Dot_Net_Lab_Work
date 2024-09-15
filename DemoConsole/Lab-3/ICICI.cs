using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_3
{
    internal class ICICI : RBI
    {
        public double CalculateInterest(double Amount,double Year)
        {
            return ((Amount * 3 * Year)/100);
        }
    }
}
