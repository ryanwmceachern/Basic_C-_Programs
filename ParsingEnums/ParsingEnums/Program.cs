using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{

    class Program
    {

        //Create an enum for the days of the week.
        enum dayofWeek
            { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

            static void Main(string[] args)
            {
            //prompt the user to enter the current day of the week.
            Console.WriteLine("Enter the current day of the week");
                string theday = Console.ReadLine();

            //Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
            try
            {

                    dayofWeek day = (dayofWeek)Enum.Parse(typeof(dayofWeek), theday);
                    Console.WriteLine("Yep thats the current day");
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                    Console.ReadLine();
                }

            }
        }
    }
    
