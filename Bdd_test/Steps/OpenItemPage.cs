using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Bdd_PageObject.Pages;
using Bdd_PageObject.Driver;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Bdd_test.Steps
{
    [Binding]
    public sealed class OpenItemPage
    {
        WebDriverWait wait = new WebDriverWait(WebDriverSingleton.getInstance(), TimeSpan.FromSeconds(15));
        //Given is located in Basic_SearchSteps.cs

        [When(@"I open first search result")]
        [Given(@"I open first search result")]
        public void WhenGivenIOpenFirstSearchResult()
        {
            MainPage mainPage = new MainPage(WebDriverSingleton.getInstance());            
            wait.Until(ExpectedConditions.ElementExists(By.XPath(mainPage.SearchPageLocator)));
            mainPage.SearchResultLink.Click();
        }

        [Then(@"the ""(.*)"" search result page is open")]
        public void ThenTheSearchResultPageIsOpen(string query)
        {
            SearchResultPage searchResultPage = new SearchResultPage(WebDriverSingleton.getInstance());
            wait.Until(ExpectedConditions.ElementExists(By.XPath(searchResultPage.SearchResultPageLocator)));
            Assert.IsTrue(searchResultPage.SearchResultTitle.Text.Contains(query));
        }
    }
}
