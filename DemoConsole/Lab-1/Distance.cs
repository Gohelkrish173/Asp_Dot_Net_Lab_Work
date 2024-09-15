using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_1
{
    internal class Distance
    {
        public double dist1;
        public double dist2;
        public double dist3;

        public Distance() { }
        public Distance(double dist1,double dist2,double dist3)
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
            this.dist3 = dist3;
        }

        public void addoutput(double dist1,double dist2,double dist3)
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
            this.dist3 = dist3;
        }

        public void DisplayOutput()
        {
            Console.WriteLine(dist1);
            Console.WriteLine(dist2);
            Console.WriteLine(dist3);
        }
    }
}
