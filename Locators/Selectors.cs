using OpenQA.Selenium;

namespace SEOchecklistKyiv.Locators
{
    class Selectors:Base
    {
        By _secondarySitemaps = By.PartialLinkText("https://");
        By _findPagesLinks  = By.PartialLinkText("https://");

        public Selectors FindSitemapsLinks()
        {
            driver.FindElement(_secondarySitemaps);
            return this;
        }
        public Selectors FindSiteLinks()
        {
            driver.FindElement(_findPagesLinks);
            return this;
        }
    }
}
