using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LactureDemo.Evaluate
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;

        public void get()
        {
            Console.WriteLine("Enter a Title : ");
            Title = Console.ReadLine();
            Console.WriteLine("Enter a Author : ");
            Author = Console.ReadLine();
            Console.WriteLine("Enter a ISBN : ");
            ISBN = Console.ReadLine();
            Console.WriteLine("Enter a Price : ");
            Price = Convert.ToDouble(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Book Title : " + Title);
            Console.WriteLine("Book Author : " + Author);
            Console.WriteLine("Book ISBN  : " + ISBN);
            Console.WriteLine("Book Price :  " + Price);
        }
    }
}
