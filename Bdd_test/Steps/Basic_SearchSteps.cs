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
        WebDriverWait wait = new WebDriverWait(WebDriverSingleton.getInstance(), TimeSpan.FromSeconds(15));

        [Given(@"I go to url")]
        public void GoToUrl()
        {
            mainPage.goToURL();
        }

        [Given(@"I set search request ""(.*)""")]
        public void GivenISetSearchRequest(string criteria)
        {
            wait.Until(ExpectedConditions.ElementExists(By.XPath(mainPage.MainPageLocator)));
            mainPage.addSearchCriteria(criteria);
        }
        
        [When(@"I perform search")]
        [Given(@"I perform search")]
        public void WhenIPerformSearch()
        {
            mainPage.clickToSearchButton();
            wait.Until(ExpectedConditions.ElementExists(By.XPath(mainPage.SearchPageLocator)));
            mainPage.PurchaseOnlyButton.Click();
            wait.Until(ExpectedConditions.ElementExists(By.XPath(mainPage.SearchPageLocator)));
        }

        [Given(@"I see on first search result price")]
        public void ISeeOnFirstSearchResultPrice()
        {
            wait.Until(ExpectedConditions.ElementExists(By.XPath(mainPage.SearchPageLocator)));
            ScenarioContext.Current.Add("Price", mainPage.SearchResultPrice.Text);
        }

        [Given(@"I see on first search result price of second product")]
        public void GivenISeeOnFirstSearchResultPriceOfSecondProduct()
        {
            wait.Until(ExpectedConditions.ElementExists(By.XPath(mainPage.SearchPageLocator)));
            ScenarioContext.Current.Add("Price2", mainPage.SearchResultPrice.Text);
        }

        
        [Then(@"the search query ""(.*)"" should be the first in the Search Result grid")]
        public void ThenTheSearchQueryShouldBeTheFirstInTheSearchResultGrid(string criteria)
        {            
            wait.Until(ExpectedConditions.ElementExists(By.XPath(mainPage.SearchPageLocator)));
            Assert.IsTrue(mainPage.SearchResult.Text.Contains(criteria));
        }
    }
}
