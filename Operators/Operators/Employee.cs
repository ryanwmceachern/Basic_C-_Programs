using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {
        //Create an Employee class with Id, FirstName and LastName properties.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator ==(Employee Obj1, Employee Obj2)
        {
            return Obj1.Id == Obj2.Id;
        }
        public static bool operator !=(Employee Obj1, Employee Obj2)
        {
            return (Obj1.Id != Obj2.Id);
        }
        
    }
}
