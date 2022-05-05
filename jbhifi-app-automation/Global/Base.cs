
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

using System;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Global
{
    class Base
    {
        #region To access Path from resource file
        public static string Url = "https://www.jbhifi.com.au/";

        #endregion



        #region setup and tear down
        [SetUp]
        public void Initialize()
        {

           driver = new ChromeDriver();

           driver.Manage().Window.Maximize();



            #region Initialise Reports


            /*extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(MarsResource.ReportXMLPath);


            test = extent.StartTest("report");*/



            #endregion


            SignIn signInlObj = new SignIn();

            signInlObj.LoginSteps();



        }


        [TearDown]
        public void TearDown()
        {
            //Screenshot
           /* String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
            test.Log(LogStatus.Info, "Image location: " + img);
            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();*/
            // Close the driver :)            
          GlobalDefinitions.driver.Close();
           // GlobalDefinitions.driver.Quit();
        }
        #endregion

    }
}