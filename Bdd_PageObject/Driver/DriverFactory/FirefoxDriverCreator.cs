using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace Bdd_PageObject.Driver.DriverFactory
{
    public class FirefoxDriverCreator:
        WebDriverCreator
    {
        public override IWebDriver factoryMethod()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            return driver;
        }
    }
}
