using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    public class Class1
    {
        public SingleUser GetUser()
        {
            var restClient = new RestClient("https://temmuzhvlstaj.atlassian.net/rest/api/3/");
            var restRequest = new RestRequest("issue/TSI-2", Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var user = JsonConvert.DeserializeObject<SingleUser>(content);
            return user;
        }

    }
}
