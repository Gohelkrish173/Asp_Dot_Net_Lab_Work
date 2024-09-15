using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_2
{
    interface Calculate1
    {
        public int Addition(int a, int b);
        public int Subtraction(int a, int b);
    }
    internal class Result : Calculate1
    {
        public int A;
        public int B;
        public string choice;

        public void GetVal()
        {
            Console.WriteLine("Enter A : ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B : ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operation (+ or -) : ");
            choice = Console.ReadLine();
        }

        public int Addition(int a, int b)
        {
            return (a + b);
        }

        public int Subtraction(int a, int b)
        {
            return (a - b);
        }
         
    }
}
