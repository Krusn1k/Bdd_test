using System;
using System.Configuration;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Bdd_PageObject.MainPage;
using 

namespace Bdd_test.Steps
{
    [Binding]
    [TestFixture]
    public class Basic_SearchSteps:
        BaseTest
    {
        [TestFixtureSetUp, Description("WebDriver init")]
        public void TestInitialize()
        {
            if (ConfigurationManager.AppSettings["driver"] == "chrome") driver = new ChromeDriver();
            if (ConfigurationManager.AppSettings["driver"] == "firefox") driver = new FirefoxDriver();
            if (ConfigurationManager.AppSettings["driver"] == "explorer") driver = new InternetExplorerDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(LoginPage.LOGIN_URL);

            /*  DesiredCapabilities capabilities = DesiredCapabilities.Chrome();
              capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));            
              driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);
              */
        }

        [Test]
        [Given(@"I set search rquest ""(.*)""")]
        public void GivenISetSearchRquest(string criteria)
        {
            MainPage mainpage = new MainPage(driver);
        }
        
        [Test]
        [When(@"I perform search")]
        public void WhenIPerformSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Test]
        [Then(@"the search query ""(.*)"" should be the first in the Search Result grid")]
        public void ThenTheSearchQueryShouldBeTheFirstInTheSearchResultGrid(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
