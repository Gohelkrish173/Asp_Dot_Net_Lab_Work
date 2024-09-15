using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_1
{
    interface Gross{
        public Double Gross_sal();
    }
    internal class Salary1 : Employee, Gross
    {
        double HRA;
        double TA;
        double DA;

        public Salary1()
        {
            basic_sal();
            Console.WriteLine("ENter HRA");
            HRA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ENter TA");
            TA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ENter DA");
            DA = Convert.ToDouble(Console.ReadLine());
        }

        public Double Gross_sal() {
            return (basic_salary + HRA + TA + DA);
        }

        public void Disp_sal()
        {
            Console.WriteLine("Name :"+ Name +"\n Gross Salary : " + Gross_sal());
        }
    }
}
