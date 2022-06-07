using jbhifi_app_automation.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace jbhifi_app_automation.Pages
{

    class AddingProduct
    {
        public AddingProduct()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
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
            SearchBar.SendKeys("Computer");
            SearchButton.Click();
            Item.Click();
            GlobalDefinitions.ImplicitWaitTime(20);

            AddToCart.Click();
            ViewCart.Click();
            GlobalDefinitions.ImplicitWaitTime(20);

            Assert.AreEqual("Venky", ProfileName.Text);
        }
    }
}