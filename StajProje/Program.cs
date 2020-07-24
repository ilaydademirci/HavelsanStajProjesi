using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Atlassian;

   namespace StajProje
{
    public class Program
    {
        public static void Main(string[] args)
        {
                var client = new RestClient();
                client.BaseUrl = new Uri("https://temmuzhvlstaj.atlassian.net");
                client.Authenticator = new HttpBasicAuthenticator("ilaydademircii_@hotmail.com", "2sMXD5XlHRS2J0Q6tfLK46E8");

                var request = new RestRequest(Method.GET);
                request.Resource = "rest/api/3/issue/TSI-2";
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json; charset=utf-8");

                request.RequestFormat = DataFormat.Json;
  
                IRestResponse response = client.Execute(request);
      
                var queryResult = client.Execute<List<JiraItem>>(request).Data;
                var JiraItem = JsonConvert.DeserializeObject<JiraItem>(response.Content);

        }

    }

    }   