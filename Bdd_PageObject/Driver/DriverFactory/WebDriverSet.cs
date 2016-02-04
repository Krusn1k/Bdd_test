using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Bdd_PageObject.Driver.DriverFactory
{
    public class WebDriverSet
    {
        private IWebDriver driver;

        public IWebDriver setDriver(string driverName)
        {
            switch (driverName)
            {
                case "chrome":
                    ChromeDriverCreator chromeCreator = new ChromeDriverCreator();
                    driver = chromeCreator.factoryMethod();
                    return driver;
                case "firefox":
                    FirefoxDriverCreator firefoxCreator = new FirefoxDriverCreator();
                    driver = firefoxCreator.factoryMethod();
                    return driver;
                case "explorer":
                    ExplorerDriverCreator explorerCreator = new ExplorerDriverCreator();
                    driver = explorerCreator.factoryMethod();
                    return driver;
                case "edge":
                    EdgeDriverCreator edgeCreator = new EdgeDriverCreator();
                    driver = edgeCreator.factoryMethod();
                    return driver;
                default:
                    return null;
            }
        }
    }
}
