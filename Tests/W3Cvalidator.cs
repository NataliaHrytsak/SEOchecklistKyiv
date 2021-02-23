using NUnit.Framework;

namespace SEOchecklistKyiv.Tests
{
   public class W3Cvalidator:Base
    {
        [Test]
        public void W3C()
        {
            All_Pages.GetAllLinks();
            for (int i = 0; i < All_Pages.siteAllLinks.Count; i++)
            {
                try
                {
                    W3C_hel_per.Validate(All_Pages.siteAllLinks[i].ToString());
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
