using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_1
{
    internal class Employee
    {
        public string Name;
        public double basic_salary;

        public void basic_sal()
        {
            Console.WriteLine("ENter Name");
            Name = Console.ReadLine();
            Console.WriteLine("ENter Basic Salary");
            basic_salary = Convert.ToDouble(Console.ReadLine());
        }
    }
}
