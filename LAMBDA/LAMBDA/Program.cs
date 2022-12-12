using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAMBDA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //in the Main() method, create a list of at least 10 employees.At least two employees should have the first name “Joe”.
            List<Employee> employees = new List<Employee>() 
            {
                new Employee(){ID = 1, FirstName = "Eddy", LastName = "Cheese" },
                new Employee(){ID = 2, FirstName = "Tim", LastName = "Charles" },
                new Employee(){ID = 3, FirstName = "Charlie", LastName = "Forest" },
                new Employee(){ID = 4, FirstName = "Joe", LastName = "Peterson" },
                new Employee(){ID = 5, FirstName = "Roberta", LastName = "Smith" },
                new Employee(){ID = 6, FirstName = "John", LastName = "Butts" },
                new Employee(){ID = 7, FirstName = "Joe", LastName = "Pecano" },
                new Employee(){ID = 8, FirstName = "Trevor", LastName = "Philips" },
                new Employee(){ID = 9, FirstName = "Charlotte", LastName = "Rose" },
                new Employee(){ID = 10, FirstName = "Elizabeth", LastName = "Potters" },
            };


            //Using a foreach loop, create a new list of all employees with the first name “Joe”.
            int counter = 0;
            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                    counter++;
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }


            }
            Console.ReadLine();

            //A lambda expression to create a new list of all employees with the first name "Joe"
            List<Employee> newList1 = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in newList1)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            Console.ReadLine();


            //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List < Employee > newList2 = employees.Where(x => x.ID > 5).ToList(); 


            foreach (Employee employee in newList2)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            Console.ReadLine();
        }
    }
}
