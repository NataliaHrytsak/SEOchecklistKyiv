using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOchecklistKyiv.Tests
{
    public class httpRedirect:Base
    {
        [Test]
        public void GetAll301()
        {
            All_Pages.GetAllLinks();
            for (int i = 0; i < All_Pages.siteAllLinks.Count; i++)
            {
                try
                {
                    http_URLs.GetURL(All_Pages.siteAllLinks[i].ToString());
                    Get_StatusCode301.GetStatus(http_URLs.AllhttpURLs[i].ToString(), All_Pages.siteAllLinks[i].ToString());
                }
                catch
                {
                    continue;
                }

            }
        }
    }
}
