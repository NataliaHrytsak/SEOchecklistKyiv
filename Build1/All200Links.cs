using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace SEOchecklistKyiv.Methods
{
    public class All200Links:Base
    {      
        [Test]
        public void GetAll200()
        {          
            All_Pages.GetAllLinks();
            for (int i = 0; i < All_Pages.siteAllLinks.Count; i++)
            {
                Page_StatusCode.GetResponse(All_Pages.siteAllLinks[i].ToString());                
            }
        }
    }
}

