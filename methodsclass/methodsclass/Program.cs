using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace methodsclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to pick two numbers one that we will add to an equation and one that will stand alone.
            Console.WriteLine("Pick a number");
            int num1 = (Console.ReadLine());
            Console.WriteLine("\nPick a second number");
            int num2 = (Console.ReadLine());

            
            //calling the math method to achive desired result of only one number being added and leaving the second number stand alone.
            mathclass method = new mathclass();
            method.math(num1, num2);
            
            //passing in values for parameters
            method.math(num1: 11, num2: 30);
            Console.ReadLine();


        }
    }
}
