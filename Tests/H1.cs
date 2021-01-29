using NUnit.Framework;

namespace SEOchecklistKyiv.Tests
{
    public class H1 : Base
    {
        [Test]
        public void GetH1()
        {
            All_Pages.GetAllLinks();
            for (int i = 0; i < All_Pages.siteAllLinks.Count; i++)
            {
                Helper_H1.CheckH1(All_Pages.siteAllLinks[i].ToString());
            }
        }
    }
}
