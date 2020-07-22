using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

   namespace StajProje
{
    public class Program
    {
        public static void Main(string[] args)
            {
            var client = new RestClient();
            client.BaseUrl = new Uri("https://temmuzhvlstaj.atlassian.net");
            client.Authenticator = new HttpBasicAuthenticator("idemirci", "123456789");

            var request = new RestRequest(Method.GET);
            request.Resource = "rest/api/3/issue/TSI-2";
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);
        }

        }

    }   