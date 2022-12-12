using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // telling the user to pick a number so we can start the math operations
            Console.WriteLine("Pick a number to get started. \n" +
                "We will now add, subtract and divide your number by 10.");

            int selectNum = Convert.ToInt32(Console.ReadLine());
            
            Theclass method = new Theclass();
            
            // Calling the Methods and printing the results.

            int One = method.math1(selectNum);
            Console.WriteLine("\n" + selectNum + " + " + 10 + " = " + One);
            
            int Two = method.math2(selectNum);
            Console.WriteLine("\n" + selectNum + " - " + 10 + " = " + Two);
            
            int Three = method.math3(selectNum);
            Console.WriteLine("\n" + selectNum + " / " + 10 + " = " + Three);

            Console.ReadLine();
        }
    }
}
