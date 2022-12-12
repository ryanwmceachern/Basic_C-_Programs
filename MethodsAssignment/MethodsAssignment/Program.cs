using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to enter two integers one mandatory one optional.
            Console.WriteLine("Enter an integer.");
            int a = (Console.ReadLine());
            Console.WriteLine("\nYou now have the option to enter a second integer to the equation. (Note this integer is optional.)");
            int b = (Console.ReadLine());
            Console.WriteLine("\nWe will now add your Integer(s).");
            

            
            
            Class1 method = new Class1();
            //A message for if the user only chooses one integer
            if (b = "")
            {
                int amount1 = a;
                int amount2 = method.math(amount1);
                Console.WriteLine("\nNo second integer found the result is:\n" +
                    a + " + " + 25 + " = " + amount2);
            }
            //If the user decides to enter two integers.
            else if (b != "")
            {
                int Amount3 = (b);
                int amount = method.math(a, Amount3);
                Console.WriteLine("\n" + a + " + " + Amount3 + " + " + 25 + " = " + amount);
            }



            Console.ReadLine();
        }
    }
}
