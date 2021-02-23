using NUnit.Framework;
using RestSharp;
using SEOchecklistKyiv.Tests;
using System;
using System.IO;
using System.Net;


namespace SEOchecklistKyiv.Methods
{
    public class GetStatusCode301:Base
    {      
        public void GetStatus(string www_address, string link)
        {            
                RestClient client = new RestClient(www_address);
                RestRequest request = new RestRequest(Method.GET);
                client.FollowRedirects = false;
                IRestResponse response = client.Execute(request);
                if (response.StatusCode.Equals(HttpStatusCode.MovedPermanently))
                {
                    RestClient secondclient = new RestClient(www_address);
                    RestRequest secondrequest = new RestRequest(Method.GET);
                    secondclient.MaxRedirects = 1;
                    IRestResponse secondresponse = secondclient.Execute(secondrequest);
                    string redirectlink = secondresponse.ResponseUri.ToString();                           
                //  Console.WriteLine(link + " " + redirectlink);
                Assert.AreEqual(link, redirectlink);
                }
                else
                {
                File.AppendAllText(@"C:\Users\dev\Desktop\All200links.txt", link + Environment.NewLine);
                // Console.WriteLine(www_address + " " + (int)response.StatusCode);
                Assert.That((int)response.StatusCode, Is.EqualTo(301));
                        
                }                   
        }
    }           
}
