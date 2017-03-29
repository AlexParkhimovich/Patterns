using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    interface PaymentStrategy
    {
        //стратегия определяет как выполнить что-то

        void DoPayment();
    }
}
