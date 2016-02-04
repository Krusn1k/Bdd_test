using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Bdd_PageObject.Driver.DriverFactory
{
    public class ChromeDriverCreator:
        WebDriverCreator
    {
        public override  IWebDriver factoryMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            return driver;
        }
    }
}
