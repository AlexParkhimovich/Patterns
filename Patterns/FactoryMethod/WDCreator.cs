using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactaryMethod
{
    public abstract class WDCreator
    {
        //создание схожих объектов относящихся к одному суперклассу, но имеют небольшую разницу в своих классах
        //пример: в организации есть сотрудники различных должностей, а значит у них различабтся права и обязанности
        //creator может создавать разные сущности разных классов 

        protected IWebDriver driver;

        public abstract IWebDriver FactoryMethod();
    }
}
