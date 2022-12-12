using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a const variable.
            const string carName = "Corolla";
            Console.WriteLine("I drive a " + carName);
            Console.ReadLine();

            //Create a variable using the keyword “var.”
            var CarBrand = "Toyota";
            Console.WriteLine("It's made by " + CarBrand);
            Console.ReadLine();

            User newUser = new User("User 1");
            
        }
    }
}
