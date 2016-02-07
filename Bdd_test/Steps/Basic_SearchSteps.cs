using System;
using System.Configuration;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Bdd_PageObject.Pages;
using Bdd_PageObject.Driver;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Bdd_test.Steps
{
    [Binding]
    public class Basic_SearchSteps
    {
        MainPage mainPage = new MainPage(WebDriverSingleton.getInstance());

        [Given(@"I go to url")]
        public void GoToUrl()
        {
            mainPage.goToURL();
        }

        [Given(@"I set search request ""(.*)""")]
        public void GivenISetSearchRequest(string criteria)
        {            
            mainPage.addSearchCriteria(criteria);
        }
        
        [When(@"I perform search")]
        [Given(@"I perform search")]
        public void WhenIPerformSearch()
        {
            mainPage.clickToSearchButton();
        }
        
        [Then(@"the search query ""(.*)"" should be the first in the Search Result grid")]
        public void ThenTheSearchQueryShouldBeTheFirstInTheSearchResultGrid(string criteria)
        {
            WebDriverWait wait = new WebDriverWait(WebDriverSingleton.getInstance(), TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(mainPage.SearchPageLocator)));
            Assert.IsTrue(mainPage.SearchResult.Text.Contains(criteria));
        }
    }
}
