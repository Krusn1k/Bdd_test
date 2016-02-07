using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Bdd_PageObject.Driver;

namespace Bdd_test.BaseTestClass
{
    public class BaseTest
    {
        public static void TestInitialize()
        {
            WebDriverSingleton.getInstance();
            WebDriverSingleton.getInstance().Manage().Window.Maximize();
            WebDriverSingleton.getInstance().Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
        }

        public static void TestCleanup()
        {
            WebDriverSingleton.closeDriver();
        }
    }
}
