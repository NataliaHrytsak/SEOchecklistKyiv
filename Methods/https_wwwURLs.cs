using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOchecklistKyiv.Methods
{
   public class https_wwwURLs
    {
        public List<string> wwwURLs = new List<string>();
        public void GetURL(string link)
        {
            if (link.Contains("https://www.bookstime.com/")|| link.Contains("https://www.gwglobalfx.com/"))
            {
                string url_without_www = "https://" + link.Substring(12);
                wwwURLs.Add(url_without_www);
            }     
            else
            {
                string httpsWwwUrl = link.Insert(8, "www.");
                wwwURLs.Add(httpsWwwUrl);
            }
        }
    }
}

