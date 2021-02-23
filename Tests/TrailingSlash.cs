using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOchecklistKyiv.Tests
{
    class TrailingSlash:Base
    {
        [Test]
        public void CheckUrls()
        {
            All_Pages.GetAllLinks();
            for (int i = 0; i < All_Pages.siteAllLinks.Count; i++)
            {
                try
                {
                    slash_helper.GetURL(All_Pages.siteAllLinks[i].ToString());
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
