using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    class Supervisor : IEmployee
    {
        private string name;
        private int hapinessLevel;
        private List<IEmployee> subordinates = new List<IEmployee>();

        public Supervisor(string name, int hapinessLevel)
        {
            this.name = name;
            this.hapinessLevel = hapinessLevel;
        }

        public void AddSubordinates(IEmployee emp)
        {
            subordinates.Add(emp);
        }

        public void ShowHapiness()
        {
            Console.WriteLine("{0} showed hapiness level of: {1}", name, hapinessLevel);
            foreach (IEmployee emp in subordinates)
            {
                emp.ShowHapiness();
            }
        }
    }
}
