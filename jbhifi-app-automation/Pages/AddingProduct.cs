using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace Target_Appliaction
{

    class AddingProduct
    {
        public AddingProduct()
        {
            PageFactory.InitElements(MarsFramework.Global.GlobalDefinitions.driver, this);
        }

        #region 
       

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Search products']")]
        private IWebElement SearchTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Search products, brands…']")]
        private IWebElement SearchBar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[title='Start Search']")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[id='product-link-552123'] h4[class='ais-hit--title product-tile__title']")]
        private IWebElement Item { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".Button-module_jbclBtn__HwYX1.Button-module_jbclBtn__primary__QQ-Lr.Button-module_jbclBtn__fullWidth__AlpoW.pdp-jss93")]
        private IWebElement AddToCart { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[id='minicart-toggle'] span[class='desktop']")]
        private IWebElement ViewCart { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".customer.customer-name")]
        private IWebElement ProfileName { get; set; }


        #endregion
        internal void SelectProduct()
        {

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("input[placeholder='Search products']"), 10);

            SearchTab.Click();
            Thread.Sleep(2000);
            SearchBar.SendKeys("Computer");
            Thread.Sleep(2000);
            SearchButton.Click();
            Thread.Sleep(7000);
            Item.Click();
            Thread.Sleep(2000);
            //ItemSize.Click();
            Thread.Sleep(2000);
            AddToCart.Click();
            Thread.Sleep(7000);
            ViewCart.Click();
            Thread.Sleep(2000);

            String actualMessage = ProfileName.Text;
            String expectedMessage = "Venky";


            GlobalDefinitions.VerifySuccessfulMessage(expectedMessage, actualMessage, "Select Product");
        }
    }
}