using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class User
    {
        //Properties of user
        public string UserName { get; set; }
        public string Location { get; set; }
        
        //Chain two constructors together.
        public User() :this("user 1")
        {

        }
        public User(string UserName) :this(UserName, "online")
        {

        }
       
        public User(string UserName, string Location)  
        {
            this.UserName = UserName;
            this.Location = Location;
        }
    }
}
