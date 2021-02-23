using NUnit.Framework;
using RestSharp;
using System;


namespace SEOchecklistKyiv.Methods
{
   public class W3C_helper
    {          
        public void Validate(string url)
        {
            var client = new RestClient("http://validator.w3.org/nu/?doc=" + url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Upgrade-Insecure-Requests", "1");
            client.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.182 Safari/537.36";
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            request.AddHeader("Sec-Fetch-Site", "same-origin");
            request.AddHeader("Sec-Fetch-Mode", "navigate");
            request.AddHeader("Sec-Fetch-User", "?1");
            request.AddHeader("Sec-Fetch-Dest", "document");
            request.AddHeader("sec-ch-ua", "\"Chromium\";v=\"88\", \"Google Chrome\";v=\"88\", \";Not A Brand\";v=\"99\"");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            request.AddParameter("text/plain", "", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);            
            string response_html = response.Content;
            string error = "<strong>Error</strong>";
            bool present = response_html.Contains(error);      
            if (present == true)
            {
                Console.WriteLine(url + " HTML has Error");
            }
            Assert.AreEqual(false, present);           
        }
    }
}
