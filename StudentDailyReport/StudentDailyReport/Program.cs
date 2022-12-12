
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you in?");
            string CourseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNumb = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help  with anything? Please answer "+ "\"true\" or \"false\".");
            string helpMe = Console.ReadLine();
            bool helpV = Convert.ToBoolean(helpMe);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string numberOfHours = Console.ReadLine();
            int numberHours = Convert.ToInt32(numberOfHours);
            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.Read();
        }
    }
}