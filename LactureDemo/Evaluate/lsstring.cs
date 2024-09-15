using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LactureDemo.Evaluate
{
    internal class lsstring
    {
        public void ls(string s)
        {
            string[] x = s.Split(" ");
            string largest = x[0];
            string smalest = x[0];

            for(int i = 0; i < x.Length; i++)
            {
                if (x[i].Length >= largest.Length)
                {
                    largest = x[i];
                }
                if (x[i].Length <= smalest.Length)
                {
                    smalest = x[i];
                }
            }
            Console.WriteLine("Largest Word : " + largest);
            Console.WriteLine("Smalest Word : " + smalest);
        }
    }
}
