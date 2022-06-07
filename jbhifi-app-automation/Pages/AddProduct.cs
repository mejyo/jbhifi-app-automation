using jbhifi_app_automation.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace jbhifi_app_automation.Pages
{
    class AddProduct
    {
        public AddProduct()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        #region 
        //Element for Search Products
        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Search products']")]
        private IWebElement SearchProducts { get; set; }

        //Element for Search Input
        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Search products, brands…']")]
        private IWebElement SearchInput { get; set; }

        //Element for Search Button
        [FindsBy(How = How.CssSelector, Using = "button[title='Start Search']")]
        private IWebElement SearchButton { get; set; }

        //Element for first item
        [FindsBy(How = How.CssSelector, Using = "a[id='product-link-552123'] h4[class='ais-hit--title product-tile__title']")]
        private IWebElement Item { get; set; }

        //Element for Add to cart
        [FindsBy(How = How.CssSelector, Using = "div[class='pdp-jss15'] span:nth-child(2)")]
        private IWebElement AddToCart { get; set; }

        //Element for My Cart
        [FindsBy(How = How.CssSelector, Using = "button[id='minicart-toggle'] span[class='desktop']")]
        private IWebElement MyCart { get; set; }

        //Element for View Cart
        [FindsBy(How = How.CssSelector, Using = "button[name='cart'] span")]
        private IWebElement ViewCart { get; set; }

        //Element for Profile name
        [FindsBy(How = How.CssSelector, Using = ".customer.customer-name")]
        private IWebElement ProfileName { get; set; }
        #endregion

        internal void AddProductSteps()
        {
            Assert.AreEqual("Jyo", ProfileName.Text);

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("input[placeholder='Search products']"), 10);
            SearchProducts.Click();
            SearchInput.SendKeys("Computer");
            SearchButton.Click();
            Item.Click();
            GlobalDefinitions.ImplicitWaitTime(10);
            AddToCart.Click();
            GlobalDefinitions.ImplicitWaitTime(10);
            MyCart.Click();
            ViewCart.Click();

            Assert.Pass("Selected product is added to the Cart!");
        }
    }
}