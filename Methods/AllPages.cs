using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;

namespace SEOchecklistKyiv.Methods
{
    public class AllPages : Base
    {    
        public AllPages(IWebDriver driver)
        {
            this.driver = driver;
        }
        public List<string> siteAllLinks = new List<string>();
        public void GetAllLinks()
        {
            string site = "https://tradeallcrypto.org/";
            string mainSitemap = site + "/sitemap_index.xml";
            driver.Navigate().GoToUrl(mainSitemap);
            var secondarySitemaps = driver.FindElements(By.PartialLinkText("https://"));
            List<string> secondaryMapsURL = new List<string>();
            foreach (IWebElement element in secondarySitemaps)
            {
                string link = element.GetAttribute("href").ToString();
                secondaryMapsURL.Add(link);
            }           
            for (int i = 0; i < secondaryMapsURL.Count; i++)
            {
                driver.Url = secondaryMapsURL[i];
                var findPagesLinks = driver.FindElements(By.PartialLinkText("https://"));
                foreach (IWebElement element in findPagesLinks)
                {
                    string pageLink = element.GetAttribute("href").ToString();
                  
                    siteAllLinks.Add(pageLink);                  
                }
            }         
        }
    }
}







