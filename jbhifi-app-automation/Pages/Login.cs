using jbhifi_app_automation.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace jbhifi_app_automation.Pages

{
    class Login
    {
        public Login()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }


        #region  Initialize Web Elements 
        //Finding the Login Icon
        [FindsBy(How = How.CssSelector, Using = "button[id='myaccount-toggle'] span[class='desktop']")]
        private IWebElement MyAccount { get; set; }

        //Finding the Email Field
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement Password { get; set; }

        //Click on login button
        [FindsBy(How = How.Id, Using = "continueProxy")]
        private IWebElement LoginButton { get; set; }
        #endregion

        internal void LoginSteps()
        {
            GlobalDefinitions.NavigateUrl();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("button[id='myaccount-toggle'] span[class='desktop']"), 10);
            MyAccount.Click();
            Email.SendKeys("hi.its.venky@gmail.com");
            Password.SendKeys("Im@jbhifi6");
            GlobalDefinitions.ImplicitWaitTime(20);
            LoginButton.Click();
        }
    }
}
