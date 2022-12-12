using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Employee Obj1 = new Employee() { Id = 47, FirstName = "Jim", LastName = "Bob" };
            Employee Obj2 = new Employee() { Id = 50, FirstName = "Henry", LastName = "Smith" };
            //printing to the console if the employees have the same Id
            Console.WriteLine("Do both employees have the same Id: " + (Obj1.Id == Obj2.Id));
           

            Console.ReadLine();
        }
    }
}
