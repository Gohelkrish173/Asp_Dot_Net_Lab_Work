using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_1
{
    internal class Furniture : Table
    {
        public String material;
        public double price;

        public void GetDetail()
        {
            material = Console.ReadLine();
            price = Convert.ToDouble(Console.ReadLine());
            Height = Convert.ToDouble(Console.ReadLine());
            surface_Area = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayFurnitureDetail()
        {
            Console.WriteLine(material);
            Console.WriteLine(price);
            Console.WriteLine(Height);
            Console.WriteLine(surface_Area);
        }
    }
}
