using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    [TestFixture]
    public class PaymentTest
    {
        private PaymentContext pc = new PaymentContext();

        [Test]
        public void OneCanPayWithVisa()
        {
            pc.paymentStrategy = new VisaPayment("alex", "1234", "2017", "234-568");
            pc.Pay();
        }

        [Test]
        public void OneCanPayWithMobile()
        {
            pc.paymentStrategy = new MobilePayment("tele2", "+123456", "tn27");
            pc.Pay();
        }

        [Test]
        public void OneCanPayWithInternet()
        {
            pc.paymentStrategy = new InternetMoneyPayment("alex", "+pass+");
            pc.Pay();
        }
    }
}
