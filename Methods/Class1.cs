using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOchecklistKyiv.Methods
{
    class Class1
    { 
        [Test]
        
        public void acv ()
        {
        string link = "https://www.bookstime.com/";
            string httpsWwwUrl = ("http" + link.Substring(5)); 
            
            Console.WriteLine(httpsWwwUrl);
        }
    }
}
