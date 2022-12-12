using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    internal class Program
    {
        static void Main()
        {

                Console.WriteLine("Income Comparison ");
                Console.ReadLine();

                Console.WriteLine("Person 1");
                Console.ReadLine();

                Console.WriteLine("Hourly Rate?");
                string HR1 = Console.ReadLine();

                Console.WriteLine("Hours worked per week?");
                string HR1W = Console.ReadLine();

                Console.WriteLine("Person 2");
                Console.ReadLine();

                Console.WriteLine("Hourly Rate?");
                string HR2 = Console.ReadLine();

                Console.WriteLine("Hours worked per week?");
                string HR2W = Console.ReadLine();

                //string to int

                Console.WriteLine("Annual salary of Person 1:");
                int HRrate = Convert.ToInt32(HR1);
                int HRworked = Convert.ToInt32(HR1W);
                int annualSalaryOne = HRrate * HRworked * 52;
                Console.WriteLine(annualSalaryOne);
                Console.ReadLine();

                //string to int
                Console.WriteLine("Annual salary of Person 2:");
                int HR2rate = Convert.ToInt32(HR2);
                int HR2worked = Convert.ToInt32(HR2W);
                int annualSalaryTwo = HR2rate * HR2worked * 52;
                Console.WriteLine(annualSalaryTwo);
                Console.ReadLine();

                //Using boolean logic
                Console.WriteLine("Does Person 1 make more money than Person 2?");
                Console.ReadLine();
                bool greaterthan = annualSalaryOne > annualSalaryTwo;
                Console.WriteLine(greaterthan);
                Console.ReadLine();

        }      
    }
}
