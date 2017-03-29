using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class VisaPayment : PaymentStrategy
    {
        private string name;
        private string cardNumber;
        private string date;
        private string code;

        public VisaPayment(string name, string cardNumber, string date, string code)
        {
            this.name = name;
            this.cardNumber = cardNumber;
            this.date = date;
            this.code = code;
        }

        public void DoPayment()
        {
            Console.WriteLine("Visa payment with user name {0}, card number {1}, card date {2} and code {3}", name, cardNumber, date, code);
        }
    }
}
