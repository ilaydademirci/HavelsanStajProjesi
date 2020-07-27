using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    /// <summary>
    /// TODO: CLASS MİMARİ YAPISI DÜZELTİLECEK
    /// </summary>
    public class JiraHelper
    {
        /// <summary>
        /// 
        /// </summary>
        public void CheckJira()
        {
            var client = new RestClient
            {
                BaseUrl = new Uri("https://temmuzhvlstaj.atlassian.net"),
                Authenticator = new HttpBasicAuthenticator("ilaydademircii_@hotmail.com", "2sMXD5XlHRS2J0Q6tfLK46E8")
            };

            var request = new RestRequest(Method.GET)
            {
                Resource = "/rest/api/3/issue/TSI-2?expand=changelog"
            };
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);
            
            var jiraItem = JsonConvert.DeserializeObject<JiraItem>(response.Content);
            

            //TSI-2 methodu transitionlarını alıyorum
            var transitions = GetTransitions("TSI-2");
        }

        public JiraTransition GetTransitions(string bugID)
        {
            var client = new RestClient
            {
                BaseUrl = new Uri("https://temmuzhvlstaj.atlassian.net"),
                Authenticator = new HttpBasicAuthenticator("ilaydademircii_@hotmail.com", "2sMXD5XlHRS2J0Q6tfLK46E8")
            };

            var request = new RestRequest(Method.GET)
            {
                Resource = "rest/api/3/issue/" + bugID + "/transitions"
            };
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);
             
            return JsonConvert.DeserializeObject<JiraTransition>(response.Content);
        }

        public void ControlJira()
        {
            var client = new RestClient
            {
                BaseUrl = new Uri("https://temmuzhvlstaj.atlassian.net"),
                Authenticator = new HttpBasicAuthenticator("ilaydademircii_@hotmail.com", "2sMXD5XlHRS2J0Q6tfLK46E8")
            };

            var request = new RestRequest(Method.GET)
            {
                Resource = "rest/api/3/issue/TSI-3?expand=changelog"
            };
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);
            
            var jiraItem = JsonConvert.DeserializeObject<JiraItem>(response.Content);


            //TSI-3 methodu transitionlarını alıyorum
            var transitions = GetTransitions2("TSI-3");

        }
        public JiraTransition GetTransitions2(string bugID)
        {
            var client = new RestClient
            {
                BaseUrl = new Uri("https://temmuzhvlstaj.atlassian.net"),
                Authenticator = new HttpBasicAuthenticator("ilaydademircii_@hotmail.com", "2sMXD5XlHRS2J0Q6tfLK46E8")
            };

            var request = new RestRequest(Method.GET)
            {
                Resource = "rest/api/3/issue/" + bugID + "/transitions"
            };
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);

            return JsonConvert.DeserializeObject<JiraTransition>(response.Content);
        }
    }
}
