using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asking the user to set the variables for the following equations.
            Console.WriteLine("Pick a integer to divide by 10.");
            int Integer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter a decimal number to add 10 and round to the nearest whole number.");
            decimal Decimal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n Enter an integer to multiply by 10");
            string String1 = Convert.ToString(Console.ReadLine());

            //Calling the class            
            Class1 method = new Class1();

            //Calling the methods
            int One = method.math(Integer);
            Console.WriteLine("\n" + Integer + " / " + 10 + " = " + One);
            
            int Two = method.math(Decimal);
            Console.WriteLine("\n" + Decimal + " + " + 10 + " = " + Two);
            
            int Three = method.math(String1);
            Console.WriteLine("\n" + String1 + " * " + 10 + " = " + Three);
            Console.ReadLine();

        }
    }
}
