using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Patterns.FactaryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactaryMethod
{
    [TestFixture]
    public class GitHubTest
    {
        [Test]
        public void FactoryTest()
        {
            WDCreator creator = new ChromeDriverCreator();
            IWebDriver driver = creator.FactoryMethod();
            driver.Navigate().GoToUrl(@"https://github.com/");
        }
    }
}
