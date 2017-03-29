using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class PaymentContext
    {
        public PaymentStrategy paymentStrategy { get; set; }

        public PaymentContext(PaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public PaymentContext()
        { }

        public void Pay()
        {
            this.paymentStrategy.DoPayment();
        }
    }
}
