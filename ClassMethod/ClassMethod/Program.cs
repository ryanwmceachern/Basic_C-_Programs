using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiating a class
            class1 object1 = new class1();

            //asking the user for a number
            Console.WriteLine("Type a number");
            string userNum = Console.ReadLine();
            int userNumber = Convert.ToInt32(userNum);

            //calling the method to the user number
            object1.multiInt(userNumber);

            //creating a method with output parameters
            int outputVar1 = 0;
            object1.multiInt(out outputVar1);
            Console.WriteLine(outputVar1);
            //Calling a method from static class
            StaticClass.static1();
            Console.ReadLine();
        }
    }
}
