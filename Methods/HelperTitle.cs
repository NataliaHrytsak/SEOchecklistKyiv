using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;


namespace SEOchecklistKyiv.Methods
{
    public class HelperTitle:Base
    {
        public HelperTitle(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CheckTitles(string link)
        {          
            driver.Url = link;
            IReadOnlyCollection<IWebElement> selectTitles = driver.FindElements(By.TagName("title"));
            bool present;
             {
                 if (selectTitles.Count > 0)
                 {                    
                    try
                     {
                      Assert.AreEqual(1, selectTitles.Count);
                     }

                     catch (Exception)
                     {
                     Console.WriteLine(link + " страница содержит более одного title");
                     Assert.AreEqual(1, selectTitles.Count);
                    }
                 }
                 else
                 {
                     present = false;
                     Console.WriteLine(link + " на странице отсутствует title ");
                     Assert.AreEqual(true, present);
                 }
             }
        }
    }
}
