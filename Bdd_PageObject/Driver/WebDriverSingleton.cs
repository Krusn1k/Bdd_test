using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Bdd_PageObject.Driver.DriverFactory;

namespace Bdd_PageObject.Driver
{
    public class WebDriverSingleton
    {
        private static IWebDriver driver;

        private WebDriverSingleton() { }

        public static IWebDriver getInstance()
        {
            if (driver == null)
            {
                WebDriverSet driverCreator = new WebDriverSet();
                driver = driverCreator.setDriver(ConfigurationManager.AppSettings["driver"]);
            };

            return driver;
        }

        public static void closeDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
