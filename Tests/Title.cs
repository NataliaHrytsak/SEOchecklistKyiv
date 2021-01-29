using NUnit.Framework;

namespace SEOchecklistKyiv.Tests
{
    public class Title : Base
    {
        [Test]
        public void GetTitle()
        {
            All_Pages.GetAllLinks();
            for (int i = 0; i < All_Pages.siteAllLinks.Count; i++)
            {
                Helper_Title.CheckTitles(All_Pages.siteAllLinks[i].ToString());
            }
        }
    }
}
