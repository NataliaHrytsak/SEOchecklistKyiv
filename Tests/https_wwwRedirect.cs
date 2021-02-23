using NUnit.Framework;
using SEOchecklistKyiv.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOchecklistKyiv.Tests
{
    public class https_wwwRedirect:Base
    {      
        [Test]
        public void GetAll301()
        {
            All_Pages.GetAllLinks();
            for (int i = 0; i < All_Pages.siteAllLinks.Count; i++)
            {
                try
                {
                    https_www_URLs.GetURL(All_Pages.siteAllLinks[i].ToString());
                    Get_StatusCode301.GetStatus(https_www_URLs.wwwURLs[i].ToString(), All_Pages.siteAllLinks[i].ToString());
                }
                catch
                {
                    continue;
                }                        
            }   
        } 
    }
}
