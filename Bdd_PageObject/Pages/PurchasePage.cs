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
    public class PurchasePage:
        AbstractPage
    {
        public PurchasePage(IWebDriver driver) 
            : base(driver)
        {
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@id='ptcBtnBottom']")]
        private IWebElement purchaseButton { get; set; }
        public IWebElement PurchaseButton
        {
            get
            {
                return purchaseButton;
            }
            set { }
        }

        [FindsBy(How = How.XPath, Using = ".//*[@class='mr10']/div/a")]
        private IWebElement itemTitle { get; set; }
        public IWebElement ItemTitle
        {
            get
            {
                return itemTitle;
            }
            set { }
        }

        [FindsBy(How = How.XPath, Using = "//span[@class='fr tr m0 p0 ff-ds3 fs16 clr000 prcol140 pb15']/div[@class='fw-b']")]
        private IWebElement itemPrice { get; set; }
        public IWebElement ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set { }
        }

        public string getPurchasePageLocator
        {
            get
            {
                return "//a[@id='ptcBtnRight']";
            }
            set { }
        }
    }
}
