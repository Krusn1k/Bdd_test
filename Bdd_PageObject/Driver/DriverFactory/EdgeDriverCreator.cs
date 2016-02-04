using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace Bdd_PageObject.Driver.DriverFactory
{
    public class EdgeDriverCreator:
        WebDriverCreator
    {
        public override IWebDriver factoryMethod()
        {
            EdgeOptions options = new EdgeOptions();
            options.PageLoadStrategy = EdgePageLoadStrategy.Eager;
            string serverPath = System.Environment.ExpandEnvironmentVariables("C:\\Program Files (x86)\\Microsoft Web Driver");
            driver = new EdgeDriver(serverPath, options);
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(10));
            return driver;
        }
    }
}
