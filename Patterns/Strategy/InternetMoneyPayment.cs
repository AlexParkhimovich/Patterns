using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class InternetMoneyPayment : PaymentStrategy
    {
        private string userID;
        private string pass;

        public InternetMoneyPayment(string userID, string pass)
        {
            this.userID = userID;
            this.pass = pass;
        }

        public void DoPayment()
        {
            Console.WriteLine("Internet payment with user id {0} and password {1}", userID, pass);
        }
    }
}
