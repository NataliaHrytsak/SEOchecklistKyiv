using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOchecklistKyiv.Methods
{
    public class http_wwwURLs
    {
        public List<string> httpwwwURLs = new List<string>();
        public void GetURL(string link)
        {
            if (link.Contains("https://www.bookstime.com/") || link.Contains("https://www.gwglobalfx.com/"))
            {
                string url_httpwithout_www = "http" + link.Substring(5);
                httpwwwURLs.Add(url_httpwithout_www);
            }
            else
            {
                string httpsWwwUrl = ("http" + link.Substring(5)).Insert(7, "www.");
                httpwwwURLs.Add(httpsWwwUrl);
            }
        }
    }
}
