using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_1
{
    internal class Staff
    {
        string Name;
        string Department;
        public string Designation;
        int Experience;
        double Salary;

        public void GetDetail()
        {
            Name = Console.ReadLine();
            Department = Console.ReadLine();
            Designation = Console.ReadLine();
            Experience = Convert.ToInt32(Console.ReadLine());
            Salary = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayDetail()
        {
            Console.WriteLine("Staff Name :" + Name);
            Console.WriteLine("Staff Salary :" + Salary);
        }
    }
}
