using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LactureDemo.Evaluate
{
    internal class EmployeeDepartment : Department
    {
        public void Display()
        {
            Console.WriteLine("Employee Id : "+EmpId);
            Console.WriteLine("Nmae : " + Name);
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Dept id : "+DeptId);
            Console.WriteLine("Dept Name : " + DeptName);
        }
    }
}
