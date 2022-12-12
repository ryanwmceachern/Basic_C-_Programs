using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 19;
            int num2 = 14;
            int num3 = 14;
            int num4 = 18;

            if (num1 > num2 && num3 < num2)
            {
                Console.WriteLine("Statement 1");
            }
            else if (num2 != num3 || num4 > num1)
            {
                Console.WriteLine("Statement 2");
            }
            else if (num3 < num1 && num1 > num2)
            {
                Console.WriteLine("Statement 3");
            }
            else if (num4 < num2 && num2 < num3)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();
        }
    }
}
