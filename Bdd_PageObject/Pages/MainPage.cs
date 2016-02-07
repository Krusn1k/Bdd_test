﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bdd_PageObject.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Bdd_PageObject.Pages
{
    public class MainPage:
        AbstractPage
    {
        public MainPage(IWebDriver driver) 
            : base(driver)
        {
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='gh-ac']")]
        private IWebElement searchField { get; set; }
        public IWebElement SearchField
        {
            get
            {
                return searchField;
            }
            set { }
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='gh-btn']")]
        private IWebElement searchButton { get; set; }
        public IWebElement SearchButton
        {
            get
            {
                return searchButton;
            }
            set { }
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ListViewInner']/li[1]")]
        private IWebElement searchResult { get; set; }
        public IWebElement SearchResult
        {
            get
            {
                return searchResult;
            }
            set { }
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ListViewInner']/li[1]/h3/a")]
        private IWebElement searchResultLink { get; set; }
        public IWebElement SearchResultLink
        {
            get
            {
                return searchResultLink;
            }
            set { }
        }
        
        [FindsBy(How = How.XPath, Using = "//div[@id='LeftNavContainer']/div/div/e1-157']")]
        private IWebElement purchaseOnlyRadioButton { get; set; }
        public IWebElement PurchaseOnlyRadioButton
        {
            get
            {
                return purchaseOnlyRadioButton;
            }
            set { }
        }

        public string SearchPageLocator
        {
            get
            {
                return "//span[@class='listingscnt']";
            }
            set { }
        }

        public string MainPageLocator
        {
            get
            {
                return "//div[@id='top']";
            }
            set { }
        }
        public void goToURL()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["url"]);
        }

        public void addSearchCriteria(string critria)
        {
            searchField.SendKeys(critria);
        }

        public void clickToSearchButton()
        {
            searchButton.Click();
        }
    }
}
