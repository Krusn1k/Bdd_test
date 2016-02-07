using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bdd_PageObject.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;

namespace Bdd_PageObject.Pages
{
    public class SearchResultPage:
        AbstractPage
    {
        public SearchResultPage(IWebDriver driver) 
            : base(driver)
        {
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//select[@id='msku-sel-1']/option[@id='msku-opt-0']")]
        private IWebElement selectColorDropDown { get; set; }
        public IWebElement SelectColorDropDown
        {
            get
            {
                return selectColorDropDown;
            }
            set { }
        }
                
        [FindsBy(How = How.XPath, Using = "//h1[@id='itemTitle']")]
        private IWebElement searchResultTitle { get; set; }
        public IWebElement SearchResultTitle
        {
            get
            {
                return searchResultTitle;
            }
            set { }
        }
        
        [FindsBy(How = How.XPath, Using = "//a[@id='isCartBtn_btn']")]
        private IWebElement addToCardButton { get; set; }
        public IWebElement AddToCardButton
        {
            get
            {
                return addToCardButton;
            }
            set { }
        }

        public string SearchResultPageLocator
        {
            get
            {
                return "//a[@id='viTabs_0']";
            }
            set { }
        }
    }
}
