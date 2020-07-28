using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje.Helpers
{
    public class RestHelper
    {
        public RestClient GenerateClient()
        {
            return new RestClient
            {
                BaseUrl = new Uri("https://temmuzhvlstaj.atlassian.net"),
                Authenticator = new HttpBasicAuthenticator("ilaydademircii_@hotmail.com", "2sMXD5XlHRS2J0Q6tfLK46E8")
            };
        }

        public RestRequest PrepareRequest(string resource)
        {
            var request = new RestRequest(Method.GET)
            {
                Resource = resource
            };
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            request.RequestFormat = DataFormat.Json;

            return request;
        }
    }
}
