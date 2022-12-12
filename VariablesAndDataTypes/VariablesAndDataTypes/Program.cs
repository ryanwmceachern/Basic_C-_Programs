using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine(" Your Name is: + yourname);
            //Console.Read();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int faveNum = Convert.ToInt32(favoriteNumber);
            //int total = faveNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isstudying = false;
            byte hoursworked = 42;
            sbyte currenttemperature = -23;
            char questionmark = '\u2103';
            decimal moneyinbank = 100.5m;
            double heightincm = 211.41431321;
            float secondsleft = 2.62f;
            short temponmars = -341;

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

        }
    }
}