using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_1
{
    internal class Bank_Account
    {
        long Account_No;
        string Email;
        string User_Name;
        string Account_Type;
        double Account_Balance;

        public void GetAccountDetails()
        {
            Console.Write("Enter Account No. :");
            Account_No = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Account Email. :");
            Email = Console.ReadLine();
            Console.Write("Enter User Name :");
            User_Name = Console.ReadLine();
            Console.Write("Enter Account_Type :");
            Account_Type = Console.ReadLine();
            Console.Write("Enter Account Balance :");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Details of User");
            Console.WriteLine("Account No:" + Account_No);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("User Name:" + User_Name);
            Console.WriteLine("Account Type:" + Account_Type);
            Console.WriteLine("Account Balance: "+ Account_Balance);
        }
    }
}
