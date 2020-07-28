using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using StajProje.Helpers;
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
        public RestHelper restHelper = new RestHelper();

        /// <summary>
        /// 
        /// </summary>
        public void CheckJira()
        {
            var client = restHelper.GenerateClient();
            var request = restHelper.PrepareRequest("/rest/api/3/issue/TSI-2?expand=changelog");

            IRestResponse response = client.Execute(request); 
            var jiraItem = JsonConvert.DeserializeObject<JiraItem>(response.Content);


            //TSI-2 methodu transitionlarını alıyorum
            var transitions = GetTransitions("TSI-2");
        }

        private void getIssue(string issueNum)
        {

        }

        public JiraTransition GetTransitions(string bugID)
        {
            var client = restHelper.GenerateClient();
            var request = restHelper.PrepareRequest("/rest/api/3/issue/TSI-2" + bugID + "/transitions");

            IRestResponse response = client.Execute(request); 
            return JsonConvert.DeserializeObject<JiraTransition>(response.Content);
        }

        //TSI-3
        public void ControlJira()
        {
            var client2 = new RestClient
            {
                BaseUrl = new Uri("https://temmuzhvlstaj.atlassian.net"),
                Authenticator = new HttpBasicAuthenticator("ilaydademircii_@hotmail.com", "2sMXD5XlHRS2J0Q6tfLK46E8")
            };

            var request2 = new RestRequest(Method.GET)
            {
                Resource = "/rest/api/3/issue/TSI-3?expand=changelog"
            };
            request2.AddHeader("Accept", "application/json");
            request2.AddHeader("Content-Type", "application/json; charset=utf-8");

            request2.RequestFormat = DataFormat.Json;

            IRestResponse response2 = client2.Execute(request2);

            var root = JsonConvert.DeserializeObject<Root>(response2.Content);


            //TSI-3 methodu transitionlarını alıyorum
            var transitions2 = GetTransitions2("TSI-3");

        }
        public JiraTransition2 GetTransitions2(string bugID)
        {
            var client2 = new RestClient
            {
                BaseUrl = new Uri("https://temmuzhvlstaj.atlassian.net"),
                Authenticator = new HttpBasicAuthenticator("ilaydademircii_@hotmail.com", "2sMXD5XlHRS2J0Q6tfLK46E8")
            };

            var request2 = new RestRequest(Method.GET)
            {
                Resource = "/rest/api/3/issue/TSI-3" + bugID + "/transitions"
            };
            request2.AddHeader("Accept", "application/json");
            request2.AddHeader("Content-Type", "application/json; charset=utf-8");

            request2.RequestFormat = DataFormat.Json;

            IRestResponse response2 = client2.Execute(request2);

            return JsonConvert.DeserializeObject<JiraTransition2>(response2.Content);
        }
    }
}
