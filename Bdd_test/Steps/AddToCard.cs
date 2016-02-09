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
    public sealed class AddToCard
    {
        WebDriverWait wait = new WebDriverWait(WebDriverSingleton.getInstance(), TimeSpan.FromSeconds(15));
        SearchResultPage searchResultPage = new SearchResultPage(WebDriverSingleton.getInstance());

        [Given(@"I select item options")]
        public void ISelectItemOptions()
        {            
            wait.Until(ExpectedConditions.ElementExists(By.XPath(searchResultPage.SearchResultPageLocator)));
            searchResultPage.SelectColorDropDown.Click();
        }        

        [When(@"I add item to card")]
        public void IAddItemToCard()
        {
            searchResultPage.AddToCardButton.Click();
        }

        [Then(@"the ""(.*)"" purchase page is open")]
        public void ThePurchasePageIsOpen(string title)
        {
            PurchasePage purchasePage = new PurchasePage(WebDriverSingleton.getInstance());
            wait.Until(ExpectedConditions.ElementExists(By.XPath(purchasePage.getPurchasePageLocator)));
            Assert.IsTrue(purchasePage.ItemTitle.Text.Contains(title));
        }

        [Then(@"the price on the purchase page such as price on the search page")]
        public void ThePriceOnThePurchasePageSuchAsPriceOnTheSearchPage()
        {
            PurchasePage purchasePage = new PurchasePage(WebDriverSingleton.getInstance());
            wait.Until(ExpectedConditions.ElementExists(By.XPath(purchasePage.getPurchasePageLocator)));
            Assert.AreEqual(purchasePage.ItemPrice.Text, ScenarioContext.Current.Get<string>("Price"));
        }
    }
}
