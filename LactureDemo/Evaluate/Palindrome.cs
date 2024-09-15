using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LactureDemo.Evaluate
{
    internal class Palindrome
    {
        public void Pld(string s)
        {
            char[] x = s.ToCharArray();
            string y = "";
            for (int i = x.Length-1; i >=0; i--) {
                y += x[i];
            }
            Console.WriteLine(x);   
            if (s == y)
            {
                Console.WriteLine("Given string is palindrome");
            }
            else {
                Console.WriteLine("Given string is not palindrome");
            }
        }
    }
}
