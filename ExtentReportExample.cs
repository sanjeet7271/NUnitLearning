
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
namespace NUnitPractice
{
    class ExtentReportExample :TestBase
    {

        IWebDriver driver;
        [Test]
        public void TestReport()
        {
            ExtentReports htmlReporter = new ExtentReports(@"D:\Reports\Reports.html");
            var test1 = htmlReporter.StartTest("TestA", "sample Description");
            test1.Log(LogStatus.Info,"initial");
       
                driver = new FirefoxDriver(@"D:\SeleniumC#\drivers");
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.selenium.dev/";
         
                IWebElement linktext = driver.FindElement(By.LinkText("Downloads"));
                linktext.Click();
                TakeScreenShot("Error", driver);
                test1.Log(LogStatus.Info,"Screenshot -"+test1.AddScreenCapture("D:\\Reports\\Error.jpeg"));
                htmlReporter.EndTest(test1);
                htmlReporter.Flush();
                driver.Quit();
        
            

            
        }
    }
}
