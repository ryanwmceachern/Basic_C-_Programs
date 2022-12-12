using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceQuoteApplication
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //The user must then be prompted for the package weight
            Console.WriteLine("Please enter package weight:");
            string weight = Console.ReadLine();

            int weight1 = Convert.ToInt32(weight);

            //If the weight is greater than 50, display the error message
            string weight2 = weight1 > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "Your package meets the weight requirement, let's continue.";
            Console.WriteLine(weight2);
            Console.ReadLine();
            if (weight1 > 50)
            {
                Environment.Exit(0);
            }


            Console.WriteLine("Please enter package width:");

            string width = Console.ReadLine();

            Console.WriteLine("Please enter package height:");
            string height = Console.ReadLine();

            Console.WriteLine("Please enter package length:");
            string length = Console.ReadLine();


            int width1 = Convert.ToInt32(width);
            int height1 = Convert.ToInt32(height);
            int length1 = Convert.ToInt32(length);

            // add dementions of the package
            int dimentions = width1 + height1 + length1;

            //If package dimentions greater then 50 then your package too big to ship. if the package is not to big multiply dimentions by weight and divide by 100 to determine shipping costs
            string canShip = dimentions > 50 ? "Package too big to be shipped via Package Express." : "Your estimated total for shipping is " + "$" + width1 * height1 * length1 * weight1 / 100 + ", Thank you!";
            Console.WriteLine(canShip);
            Console.ReadLine();
            if (dimentions > 50)
            {
                Environment.Exit(0);
            }

        }
    }
}
