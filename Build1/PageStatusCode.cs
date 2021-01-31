using NUnit.Framework;
using RestSharp;
using System;
using System.IO;
using System.Linq;
using System.Net;

namespace SEOchecklistKyiv.API
{
    public class PageStatusCode:Base
    {     
        public void GetResponse(string link)
        {
            RestClient client = new RestClient(link);
            RestRequest request = new RestRequest(Method.GET);
            client.FollowRedirects = false;
            IRestResponse response = client.Execute(request);
            try
            {
                Assert.That((int)response.StatusCode, Is.EqualTo(200));
                File.AppendAllText(@"C:\Users\dev\source\repos\SEOchecklistKyiv\Build1\All200links.txt", link + Environment.NewLine);
            }
            catch (Exception)
            {
                if (response.StatusCode.Equals(HttpStatusCode.MovedPermanently) || response.StatusCode.Equals(HttpStatusCode.Found) || response.StatusCode.Equals(HttpStatusCode.TemporaryRedirect))
                {
                    string redirectlink = response.Headers.Where(x => x.Name == "Location").Select(y => y.Value).FirstOrDefault().ToString();
                    //File.AppendAllText(@"C:\Users\dev\Desktop\No200Links.txt", link + (int)response.StatusCode + " to " + redirectlink + Environment.NewLine);
                    Assert.That((int)response.StatusCode, Is.EqualTo(200));
                }
            }
            finally
            {
                if ((response.StatusCode != HttpStatusCode.OK) && (response.StatusCode != HttpStatusCode.MovedPermanently) && (response.StatusCode != HttpStatusCode.Found) && (response.StatusCode != HttpStatusCode.TemporaryRedirect))
                {
                    //File.AppendAllText(@"C:\Users\dev\Desktop\No200Links.txt", link + (int)response.StatusCode + Environment.NewLine);
                    Assert.That((int)response.StatusCode, Is.EqualTo(200));
                }
            }
        }
    }
}
