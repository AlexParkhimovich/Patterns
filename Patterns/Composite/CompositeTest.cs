using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    [TestFixture]
    class CompositeTest
    {
        [Test]
        public void TestComposite()
        {
            Worker tom = new Worker("worker Tom", 5);
            Worker jimmy = new Worker("worker Jimmy", 6);

            Supervisor mary = new Supervisor("Mary", 7);
            mary.AddSubordinates(tom);
            Supervisor jerry = new Supervisor("Jerry", 8);
            jerry.AddSubordinates(jimmy);

            Supervisor bob = new Supervisor("Bob", 10);
            bob.AddSubordinates(mary);
            bob.AddSubordinates(jerry);

            tom.ShowHapiness();
            jimmy.ShowHapiness();

            mary.ShowHapiness();

            Console.WriteLine("****");
            bob.ShowHapiness();
        }
    }
}
