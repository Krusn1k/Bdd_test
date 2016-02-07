using System;
using System.Configuration;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Bdd_PageObject.Pages;
using Bdd_test.BaseTestClass;
using Bdd_PageObject.Driver;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Bdd_test.Steps
{
    [Binding]
    class BeforeAfterFeature
    {
        [BeforeFeature]
        public static void Before()
        {
            BaseTest.TestInitialize();
        }

        [AfterFeature]
        public static void After()
        {
            BaseTest.TestCleanup();
        }
    }
}
