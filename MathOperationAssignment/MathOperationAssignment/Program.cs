using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Takes an input from the user, multiplies it by 50, and prints the result to the console.
            Console.WriteLine("1. Type a number to multiply by 50.");
            int product = Int32.Parse(Console.ReadLine()) * 50;
            Console.WriteLine("The answer is " + product);


            //2. Takes an input from the user, adds 25 to it, and prints the result to the console
            Console.WriteLine("2. Type a number to add 25 to it.");
            int total = Int32.Parse(Console.ReadLine()) + 25;
            Console.WriteLine("The answer is " + total);

            //3. Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("3. Type a number to divide by 12.5.");
            double quotient = double.Parse(Console.ReadLine()) / 12.5;
            Console.WriteLine("The answer is " + quotient);

            //4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
            Console.WriteLine("4. Type a number to see if it is greater than 50.");
            bool checker = double.Parse(Console.ReadLine()) > 50;
            Console.WriteLine(checker.ToString());

            //5. Takes an input from the user, divides it by 7, and prints the remainder to the console
            Console.WriteLine("5. Type a number to find out the remiander after it has been divided by 7.");
            double remainder = double.Parse(Console.ReadLine()) % 7;
            Console.WriteLine("The answer is " + remainder);
            Console.Read();


        }
    }
}
