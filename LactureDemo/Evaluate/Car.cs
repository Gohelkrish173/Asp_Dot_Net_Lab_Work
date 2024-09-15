using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LactureDemo.Evaluate
{
    internal class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public double price;

        public void get()
        {
            Console.WriteLine("Enter a Make : ");
            Make = Console.ReadLine();
            Console.WriteLine("Enter a Model : ");
            Model = Console.ReadLine();
            Console.WriteLine("Enter a Year : ");
            Year = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a Price : ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Book Title : " + Make);
            Console.WriteLine("Book Author : " + Model);
            Console.WriteLine("Book ISBN  : " + Year);
            Console.WriteLine("Book Price :  " + price);
        }
    }
}
