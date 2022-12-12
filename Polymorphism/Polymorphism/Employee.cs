using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{   
    //Created the Employee class and having it enherit IQuittable interface.
    public class Employee: IQuittable 
    {
        
        public void Quit()
        {
            Console.WriteLine("Oh No, The Employee Quit");
        }
    }
}
