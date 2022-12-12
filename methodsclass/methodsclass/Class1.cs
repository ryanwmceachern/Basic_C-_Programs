using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsclass
{
    internal class mathclass
    {
        public void math(int num1, int num2)
        {
            int Total = num1 + 10;
            Console.WriteLine("\nyour number {0} plus ten = " + Total + ".", num1);
            Console.WriteLine("\nyour number {0} is not included in the operation", num2);
            return;
        }
    }
}

