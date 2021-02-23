using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SEOchecklistKyiv.API;
using SEOchecklistKyiv.Methods;
using SEOchecklistKyiv.Tests;
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
        public https_wwwURLs https_www_URLs;
        public GetStatusCode301 Get_StatusCode301;
        public httpURLs http_URLs;
        public http_wwwURLs http_www_URLs;
        public SlashHelper slash_helper;
        public MixedContentHelper mixed_ContentHelper;
        public W3C_helper W3C_hel_per;

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
            https_www_URLs = new https_wwwURLs();
            Get_StatusCode301 = new GetStatusCode301();
            http_URLs = new httpURLs();
            http_www_URLs = new http_wwwURLs();
            slash_helper = new SlashHelper();
            mixed_ContentHelper = new MixedContentHelper(driver);
            W3C_hel_per = new W3C_helper();
        }

        [OneTimeTearDown]
        public void OnTestEnded()
        {
            driver.Close();
        }
    }
}
