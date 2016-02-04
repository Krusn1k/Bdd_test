using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace Bdd_PageObject.Driver.DriverFactory
{
    public class ExplorerDriverCreator:
        WebDriverCreator
    {
        public override IWebDriver factoryMethod()
        {
            driver = new InternetExplorerDriver();
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            return driver;
        }
    }
}
