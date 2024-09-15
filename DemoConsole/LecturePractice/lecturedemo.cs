using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.LecturePractice
{
    internal class lecturedemo
    {
        int salary = 0;

        public lecturedemo(int salary)
        {
            this.salary = salary;
        }

        public void IncSalary()
        {
            Console.WriteLine(salary + salary * 10 / 100);
        }
    }
}
