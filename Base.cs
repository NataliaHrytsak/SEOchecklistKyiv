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
        public AllLinks All_Pages;
        public PageStatusCode Page_StatusCode;
        public HelperTitle Helper_Title;
        public HelperH1 Helper_H1;
        public CanonicalHelper Canonical_Helper;
        public IframeHelper Iframe_Helper;

        [OneTimeSetUp]
        public void OnTestStarted()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            All_Pages = new AllLinks(driver);
            Page_StatusCode = new PageStatusCode();
            Helper_Title = new HelperTitle(driver);
            Helper_H1 = new HelperH1(driver);
            Canonical_Helper = new CanonicalHelper(driver);
          //  Iframe_Helper = new IframeHelper(driver);
        }

        [OneTimeTearDown]
        public void OnTestEnded()
        {
            driver.Close();
        }
    }
}
