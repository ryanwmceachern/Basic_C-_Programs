using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    public class class1
    {
        //dividing method
        public void multiInt(int userInt)
        {
           
            //math operation on userint that divides by two 
            int answerInt = userInt / 2;
            //Display the output to the screen.
            Console.WriteLine(answerInt);
        }

        //overloading a method
        public void multiInt(out int multiInt)
        {
            multiInt = 20;
        }
    }
}
