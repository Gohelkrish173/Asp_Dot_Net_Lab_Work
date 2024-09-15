using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_2
{
    public class DivideByZero : Exception
    {
        public DivideByZero(String message) : base(message) { }
    }
    internal class DivideZeroExce
    {
        public double a, b;

        public void getDetail()
        {
            Console.WriteLine("Enter A :");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter A :"); 
            b = Convert.ToDouble(Console.ReadLine());

            if(b == 0)
            {
                throw new DivideByZero("Invalid input, b is not zero");
            }
        }
    }
}
