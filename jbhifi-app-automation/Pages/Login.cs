using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace MarsFramework.Pages

{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }


        #region  Initialize Web Elements 
        //Finding the Sign Icon
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

       /* [FindsBy(How = How.CssSelector, Using = ".Typography-module_jbclTyp__link__e95fz.Typography-module_jbclTyp__roboto__ioyYr")]
        private IWebElement SkipButton { get; set; }*/



        #endregion
        internal void LoginSteps()
        {
            GlobalDefinitions.NavigateUrl();


            Thread.Sleep(3000);

            MyAccount.Click();

            Thread.Sleep(3000);

            Email.SendKeys("jyothi.d1812@gmail.com");
            Thread.Sleep(2000);
            Password.SendKeys("Im@target6");
            Thread.Sleep(2000);
            LoginButton.Click();
            Thread.Sleep(9000);
          //  SkipButton.Click();



        }
    }
}
