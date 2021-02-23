using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOchecklistKyiv.Methods
{
    public class httpURLs
    {
        public List<string> AllhttpURLs = new List<string>();
        public void GetURL(string link)
        { 
          string httpUrl = "http" + link.Substring(5); 
          AllhttpURLs.Add(httpUrl);       
        }
    }
}
