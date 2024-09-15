using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_3
{
    internal class Apollo : Hospital
    {
        public void HospitalDetails(string hname, double rating)
        {
            Console.WriteLine("Apollo Hospital details");
            Console.WriteLine(hname);
            Console.WriteLine(rating);
        }
    }
}
