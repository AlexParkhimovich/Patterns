using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public User(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public User()
        { }

        public User AddFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public override string ToString()
        {
            return "User(" + "firstName= " + firstName + ", lastName= " + lastName + ", age= " + age + ")";
        }
    }
}
