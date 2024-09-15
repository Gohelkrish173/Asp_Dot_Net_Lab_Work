using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_3
{
    internal class factorial
    {
        
        public int fact(int n) {
            int  ans = 1;
            for (int i = 1; i <= n; i++)
            {
                ans = ans * i;
            }
            return ans;
        }
    }
}
