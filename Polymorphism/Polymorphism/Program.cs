using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Use polymorphism to create an object of type IQuittable
            IQuittable Obj1 = new Employee();

            //call the Quit() method on it.
            Obj1.Quit(); 
            Console.ReadLine();
        }
    }
}
