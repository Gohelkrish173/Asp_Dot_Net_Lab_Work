using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_1
{
    internal class Salary
    {
        double Basic;
        double TA;
        double DA = .1;
        double HRA = .2;

        public Salary(double basic,double TA) {
            Basic = basic;
            this.TA = TA;
        }

        public void CalculateSalary()
        {
            double TotalSalary = Basic + TA + (Basic * DA) + (TA * HRA);
            Console.WriteLine("Total Salary : "+TotalSalary);
        }


    }
}
