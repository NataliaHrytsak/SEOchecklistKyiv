using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SEOchecklistKyiv.Methods
{
    public class MixedContentHelper : Base
    {
        public MixedContentHelper(IWebDriver driver)
        {
            this.driver = driver;
        }
        public List<string> contentLinks = new List<string>();
        public void CheckProtocol(string link)
        {
            bool present = true;
            driver.Url = link;            
            var httpLinks = driver.FindElements(By.PartialLinkText("http://"));
            List<string> links = new List<string>();
            foreach (IWebElement element in httpLinks)
            {
                try
                {
                    string hrefValue = element.GetAttribute("href").ToString();
                    links.Add(hrefValue);
                }
                catch
                {
                    continue;
                }
            }            
            var contentLinks = driver.FindElements(By.CssSelector("[script*='http://']"));
            foreach (IWebElement element in contentLinks)
            {
                try
                {
                    string httpLink = element.GetAttribute("script").ToString();
                    links.Add(httpLink);
                }
                catch
                {
                    continue;
                }
            }
            var contentLinks2 = driver.FindElements(By.CssSelector("[src*='http://']"));
            foreach (IWebElement element in contentLinks2)
            {
                try
                {
                    string httpLink2 = element.GetAttribute("script").ToString();
                    links.Add(httpLink2);
                }
                catch
                {
                    continue;
                }
            }
            var contentLinks3 = driver.FindElements(By.CssSelector("[content*='http://']"));
            foreach (IWebElement element in contentLinks3)
            {
                try
                {
                    string httpLink3 = element.GetAttribute("content").ToString();
                    links.Add(httpLink3);
                }
                catch
                {
                    continue;
                }
            }
            var contentLinks4 = driver.FindElements(By.CssSelector("[location*='http://']"));
            foreach (IWebElement element in contentLinks4)
            {
                try
                {
                    string httpLink4 = element.GetAttribute("location").ToString();
                    links.Add(httpLink4);
                }
                catch
                {
                    continue;
                }
            }
            var contentLinks5 = driver.FindElements(By.CssSelector("[url*='http://']"));
            foreach (IWebElement element in contentLinks5)
            {
                try
                {
                    string httpLink5 = element.GetAttribute("url").ToString();
                    links.Add(httpLink5);
                }
                catch
                {
                    continue;
                }
            }
            var contentLinks6 = driver.FindElements(By.CssSelector("[origin*='http://']"));
            foreach (IWebElement element in contentLinks6)
            {
                try
                {
                    string httpLink6 = element.GetAttribute("origin").ToString();
                    links.Add(httpLink6);
                }
                catch
                {
                    continue;
                }
            }
            if (links.Count > 0)
            {
                Assert.AreEqual(present, false);
                Console.WriteLine(links);
            }
        }
    }
}
