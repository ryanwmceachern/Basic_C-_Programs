using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Prints the current date and time to the console.
            Console.WriteLine("The current time and date is: " + DateTime.Now);
            Console.ReadLine();

            //Asks the user for a number.
            Console.WriteLine("Pick a number.");

            //turns the user int into an x variable
            int x = Convert.ToInt32(Console.ReadLine());
            TimeSpan userInt = new TimeSpan(0, x, 0, 0); 
            DateTime TimeNow = DateTime.Now; 
            DateTime Xtime = TimeNow.Add(userInt); 
            string FutureTime = Xtime.ToString();
            
            //Prints to the console the exact time it will be in X hours.
            Console.WriteLine("In " + x + " hours it will be exactly: " + FutureTime);
            Console.ReadLine();
        }
    }
}
