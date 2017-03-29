using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class MobilePayment : PaymentStrategy
    {
        private string mobileOperator;
        private string mobileNumber;
        private string code;

        public MobilePayment(string mobileOperator, string mobileNumber, string code)
        {
            this.mobileOperator = mobileOperator;
            this.mobileNumber = mobileNumber;
            this.code = code;
        }

        public void DoPayment()
        {
            Console.WriteLine("Mobile payment with user mobile operator {0}, mobile number {1} and code {2}", mobileOperator, mobileNumber, code);
        }
    }
}
