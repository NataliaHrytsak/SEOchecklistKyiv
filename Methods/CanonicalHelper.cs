using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace SEOchecklistKyiv.Methods
{
    public class CanonicalHelper:Base
    {
        public CanonicalHelper(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CheckCanonical(string link)
        {
            driver.Url = link;
            IReadOnlyCollection<IWebElement> selectCanonical = driver.FindElements(By.CssSelector("link[rel='canonical']"));
            bool present;
            {
                if (selectCanonical.Count > 0)
                {
                    try
                    {
                        Assert.AreEqual(1, selectCanonical.Count);
                    }

                    catch (Exception)
                    {
                        Console.WriteLine(link + " страница содержит более одного canonical");
                    }
                }
                else
                {
                    present = false;
                    Console.WriteLine(link + " на странице отсутствует canonical");
                    Assert.AreEqual(true, present);
                }
            }
        }
    }
}
