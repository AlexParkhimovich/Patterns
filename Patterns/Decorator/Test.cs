using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    
    class Test
    {
        [Test]
        public void abc()
        {
            IWebDriver driver = new ChromeDriver();//создаю эеземпляр драйвера

            //IWebDriver customDriver = new Decorator(driver); // декорирую драйвер
        }
    }
}
