using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TryOne()
        {
            IWebDriver driver = WDSingleTon.GetInstance();
            driver.Navigate().GoToUrl(@"https://github.com/");
        }

        [Test]
        public void TryTwo()
        {
            IWebDriver driver = WDSingleTon.GetInstance();
            driver.Navigate().GoToUrl(@"http://stackoverflow.com/");
        }

        [OneTimeTearDown]
        public void Quit()
        {
            WDSingleTon.WDQuit();
        }
    }
}
