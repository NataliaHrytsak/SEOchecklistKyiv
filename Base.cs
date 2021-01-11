using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SEOchecklistKyiv.API;
using SEOchecklistKyiv.Methods;
using System.Collections.Generic;

namespace SEOchecklistKyiv
{
    public class Base
    {
        public IWebDriver driver;
        public AllPages All_Pages;
        public PageStatusCode Page_StatusCode;      

        [OneTimeSetUp]
        public void OnTestStarted()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            All_Pages = new AllPages(driver);
            Page_StatusCode = new PageStatusCode();
        }

        [OneTimeTearDown]
        public void OnTestEnded()
        {
            driver.Close();
        }
    }
}
