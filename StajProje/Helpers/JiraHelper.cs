using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using StajProje.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        public async Task  Loadid(int id=0)
        {
            string url= "",

                if(id>0)
            {
                url =
            }
            else
            {
                url =
            }
            using (HttpResponseMessage response = await RestHelper.GenerateClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Departmentdepartment = awaitresponse.Content.ReadAsAsync<Department>();
                    Console.WriteLine("Id:{0}\tName:{1}", department.DepartmentId, department.DepartmentName);
                    Console.WriteLine("No of Employee in Department: {0}", department.Employees.Count);
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
        }
    }
}
