using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instantiate an Employee object with firstName “Sample” and lastName “Student”.
            Employee NewEmployee = new Employee()
            { FirstName = "Sample", LastName = "Student" };
            //Call the SayName() method on the object.
            NewEmployee.SayName();
            Console.ReadLine();
        }
    }
    
}
