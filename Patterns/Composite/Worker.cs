using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    class Worker : IEmployee
    {
        private string name;
        private int hapinessLevel;

        public Worker(string name, int hapinessLevel)
        {
            this.name = name;
            this.hapinessLevel = hapinessLevel;
        }

        public void ShowHapiness()
        {
            Console.WriteLine("{0} showed hapiness level of: {1}", name, hapinessLevel);
        }
    }
}
