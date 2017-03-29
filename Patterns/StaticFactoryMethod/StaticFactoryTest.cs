using NUnit.Framework;
using Patterns.StaticFactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    [TestFixture]
    public class StaticFactoryTest
    {
        [Test]
        public void TestUser()
        {
            User alex = StaticFactory.CreateDefaultUser();
            Console.WriteLine(alex.ToString());

            User anton = StaticFactory.CreateUserByBirthYear(1983);
            Console.WriteLine(anton.ToString());
            anton.AddFirstName("anton");
            Console.WriteLine(anton.ToString());

            User ivan = StaticFactory.CreateDefaultUser().AddFirstName("ivan");
            Console.WriteLine(ivan.ToString());
        }
    }
}
