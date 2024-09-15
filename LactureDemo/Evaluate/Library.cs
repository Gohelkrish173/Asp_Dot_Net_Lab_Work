using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LactureDemo.Evaluate
{
    internal class Library : Book
    {
        int n = Convert.ToInt16(Console.ReadLine());
        
        List<string> list = new List<string>();
        
        public void get()
        {
            Console.WriteLine("Enter Title : ");
            Title = Console.ReadLine();
            list.Add(Title);
        }
        public void display()
        {
            for (int i = 0; i < list.Count; i++) { 
                Console.WriteLine(list[i]);
            }
        }
        public void search(string s)
        {
            if (list.Contains(s))
            {
                Console.WriteLine("Book is Available");
            }
            else
            {
                Console.WriteLine("Book is not Available");
            }
        }
    }
}
