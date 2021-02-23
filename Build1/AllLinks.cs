using OpenQA.Selenium;
using System.Collections.Generic;


namespace SEOchecklistKyiv.Methods
{
    public class AllLinks : Base
    {    
        public AllLinks(IWebDriver driver)
        {
            this.driver = driver;
        }
        public List<string> siteAllLinks = new List<string>();
        public void GetAllLinks()
        {
            string site = "https://boriscooper.org/";
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







