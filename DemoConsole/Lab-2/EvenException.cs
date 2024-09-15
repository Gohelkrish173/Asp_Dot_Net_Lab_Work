using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_2
{
    internal class EvenException : Exception
    {
        public EvenException(string message) : base(message) { }
    }
}
