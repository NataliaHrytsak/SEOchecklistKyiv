using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOchecklistKyiv.Tests
{
   public class MixedContent:Base
    {
        [Test]
        public void CheckUrls()
        {
            All_Pages.GetAllLinks();
            for (int i = 0; i < All_Pages.siteAllLinks.Count; i++)
            {
                try
                {
                    mixed_ContentHelper.CheckProtocol(All_Pages.siteAllLinks[i].ToString());
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
