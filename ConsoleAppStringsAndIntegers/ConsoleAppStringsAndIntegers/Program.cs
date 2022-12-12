using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsAndIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating a list of ints.
            
            Console.WriteLine("Numbers List:");
            List<int> numberList = new List<int>() { 100, 200, 300, 400, 500 };

            // Asking the user to enter a number and printing a message letting the user know we will devide the list by the number they selected
            // Creating a loop that will take each number from the list and divide it by the number entered.
            
            foreach (int num in numberList)
            {
                Console.WriteLine(num);
            }
            
            //adding the try catch block
            
            try
            {
                Console.WriteLine("\n type a number:");
                Console.WriteLine("\nEach number in the list will now be divided by the number you entered.\n");
                int Number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                foreach (int number in numberList)
                {
                    int answer = number / Number1;
                    Console.WriteLine(answer);
                }
            }
            
            //if a non whole number, this error message will display.
            
            catch (FormatException ex)
            {
                Console.WriteLine("\nPlease, enter a whole number.\n" + ex.Message);
            }
            
            // If zero, this error message will display.
            
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nYou cannot use zero.\n" + ex.Message);
            }
            
            // This error message will displayed for any other exception.
            
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
            }
            
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
