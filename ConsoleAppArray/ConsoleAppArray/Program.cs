using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                //Create a list of strings
                Console.WriteLine("Select an index from 0 to 3.");
                List<string> list1 = new List<string>() { "Toyota", "Mazda", "Ford", "Dodge" };
                int list2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value of the selected index is: " + list1[list2]);
                Console.ReadLine();

                //create a one-dimensional Array of strings. 

                Console.WriteLine("Select an index from 0 to 4.");
                string[] stringArray = { "cat", "mouse", "dog", "tiger", "leopard" };
                int stringg = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value of the selected index is: " + stringArray[stringg]);
                Console.ReadLine();

                //Create a one-dimensional Array of integers
                try
                {
                    Console.WriteLine("Select an index from 0 to 4.");
                    int[] numArray = { 11, 47, 22, 63, 95 };
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine("The value of the selected index is: " + numArray[input]);
                    Console.ReadLine();
                }
                catch (System.IndexOutOfRangeException)
                {

                    {
                        //message that displays when the user selects an index that doesn’t exist.

                        Console.WriteLine("Selected index does not exist.");
                    }

                    Console.ReadLine();

                   


                }




            }
        }
    }
}
