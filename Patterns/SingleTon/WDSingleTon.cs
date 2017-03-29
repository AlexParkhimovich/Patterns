using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class WDSingleTon
    {
        private static IWebDriver driver;

        private WDSingleTon()
        { }

        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }

        public static void WDQuit()
        {
            driver.Quit();
            driver = null;
        }
    }
}
