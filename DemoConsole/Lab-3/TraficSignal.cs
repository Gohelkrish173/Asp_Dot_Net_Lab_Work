using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_3
{
    internal class TraficSignal
    {
        public void Yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }
        public void Green()
        {
            Console.WriteLine("Green Light Signal To Go");
        }
        public void Red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }
    }
}
