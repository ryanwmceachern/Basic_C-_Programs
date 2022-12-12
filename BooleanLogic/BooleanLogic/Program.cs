using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    internal class Program
    {
        static void Main()
        {
            //Ask the following questions:
            Console.WriteLine("What is your age?");
            string AGE = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? True or False.");
            string DUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string TICKETS = Console.ReadLine();

            
            int pAge = Convert.ToInt32(AGE);
            int pTickets = Convert.ToInt32(TICKETS);
            bool pDUI = bool.Parse(DUI);

            //Qualification rules to determine if the applicant qualifies for car insurance:
            Console.WriteLine("Is this person qualified for car insurance?");
            bool qualified = (pAge >= 15 && pDUI == false && pTickets <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
            
        }
    }
}
