﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Bdd_PageObject.Driver;

namespace Bdd_test.BaseTestClass
{
    public abstract class BaseTest
    {

        [TestFixtureSetUp, Description("WebDriver init")]
        public void TestInitialize()
        {
            WebDriverSingleton.getInstance();
            WebDriverSingleton.getInstance().Manage().Window.Maximize();
            WebDriverSingleton.getInstance().Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
        }

        [TestFixtureTearDown, Description("WebDriver clean up")]
        public void TestCleanup()
        {
            WebDriverSingleton.closeDriver();
        }
    }
}
