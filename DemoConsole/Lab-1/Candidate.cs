using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_1
{
    internal class Candidate
    {
        int Id;
        string Name;
        int Age;
        double Weight;
        double Height;

        public void GetCandidateDetail()
        {
            Id = Convert.ToInt16(Console.ReadLine());
            Name = Console.ReadLine();
            Age = Convert.ToInt16(Console.ReadLine());
            Weight = Convert.ToDouble(Console.ReadLine());
            Height = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCandidateDetail()
        {
            Console.WriteLine("Candidate Details");
            Console.WriteLine("Id : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Weight : " + Weight);
            Console.WriteLine("Height : " + Height);
        }
    }
}
