using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    
    internal class Class1
    {
        
        public double math(int num1, [Optional] int num2)
        {
            double totalAmount = num1 + num2 + 25;
            return totalAmount;
        }


    }
}
