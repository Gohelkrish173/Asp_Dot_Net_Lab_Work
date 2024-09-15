using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_1
{
    internal class Account_Details
    {
        long Account_No;
        string User_Name;
        public double Amount;
        public int Years;
        public double Rate;

        public void GetDetails()
        {
            Console.WriteLine("Account No. : ");
            Account_No = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Account UserName. : ");
            User_Name = Console.ReadLine();
            Console.WriteLine("Amount : ");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Years : ");
            Years = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Rate : ");
            Rate = Convert.ToDouble(Console.ReadLine());
        }

    }

    class Interest : Account_Details
    {
        public Double DisplayInterest()
        {
            return ((Amount * Rate * Years) / 100);
        }
    }
}
