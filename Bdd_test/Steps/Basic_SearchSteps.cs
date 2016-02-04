using System;
using System.Configuration;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Bdd_PageObject.MainPage;
using Bdd_test.BaseTestClass;
using Bdd_PageObject.Driver;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Bdd_test.Steps
{
    [Binding]
    [TestFixture]
    public class Basic_SearchSteps:
        BaseTest
    {
        MainPage mainPage = new MainPage(WebDriverSingleton.getInstance());

        [Given(@"I set search rquest ""(.*)""")]
        public void GivenISetSearchRquest(string criteria)
        {
            mainPage.goToURL();
            mainPage.addSearchCriteria(criteria);
        }
        
        [When(@"I perform search")]
        public void WhenIPerformSearch()
        {
            mainPage.clickToSearchButton();
        }
        
        [Test]
        [Then(@"the search query ""(.*)"" should be the first in the Search Result grid")]
        public void ThenTheSearchQueryShouldBeTheFirstInTheSearchResultGrid(string criteria)
        {
            WebDriverSingleton.getInstance().Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            WebDriverWait wait = new WebDriverWait(WebDriverSingleton.getInstance(), TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//li[@r='1']/h3/a")));
            Assert.IsTrue(mainPage.SearchResult.Text.Contains(criteria));
        }
    }
}
