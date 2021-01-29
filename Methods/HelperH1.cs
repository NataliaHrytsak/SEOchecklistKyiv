using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;


namespace SEOchecklistKyiv.Methods
{
    public class HelperH1:Base
    {
        public HelperH1(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CheckH1(string link)
        {
            driver.Url = link;
            IReadOnlyCollection<IWebElement> selectH1 = driver.FindElements(By.TagName("h1"));
            bool present;
            {
                if (selectH1.Count > 0)
                {
                    try
                    {
                        Assert.AreEqual(1, selectH1.Count);
                    }

                    catch (Exception)
                    {
                        Console.WriteLine(link + " страница содержит более одного h1");
                    }
                }
                else
                {
                    present = false;
                    Console.WriteLine(link + " на странице отсутствует h1 ");
                    Assert.AreEqual(true, present);
                }
            }
        }
    }
}

