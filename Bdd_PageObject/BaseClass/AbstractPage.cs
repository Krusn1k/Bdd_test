using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Bdd_PageObject.BaseClass
{
    public abstract class AbstractPage
    {
        protected IWebDriver driver;

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
