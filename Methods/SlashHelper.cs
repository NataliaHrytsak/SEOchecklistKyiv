using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOchecklistKyiv.Methods
{
   public class SlashHelper
    {
        public void GetURL(string link)
        {
            if (link.Contains("https://www.bookstime.com"))
            {
                bool end = link.EndsWith("/");
                if (end is true)
                {
                    Console.WriteLine(link);
                }
                Assert.That(end is false);
            }

            else if (link.Contains("https://www.bookstime.com") is false)
            {
                bool end = link.EndsWith("/");
                if (end is false)
                {
                    Console.WriteLine(link);
                }            
                Assert.That(end is true);
            }
        }
    }
}
