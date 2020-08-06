using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using StajProje.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Atlassian;
using StajProje.Base;

namespace StajProje
{
    /// <summary>
    /// TODO: CLASS MİMARİ YAPISI DÜZELTİLECEK
    /// </summary>
    public class JiraHelper
    {
        public RestHelper restHelper = new RestHelper();
        public ExcelHelper excelHelper = new ExcelHelper();
        public Dictionary<string, int> reboundDictionary = new Dictionary<string, int>();

        /// <summary>
        /// 
        /// </summary>
        /// 
        public void CheckJira()
        {
            var buglist = GetAllBugs();


            foreach (Issue bug in buglist)
            {
                var history = GetHistory(bug.key); //TSI-2
                int reboundCount = CalculateRebound(history);
                reboundDictionary.Add(bug.key, reboundCount);
                Console.WriteLine("Bug: {0}", bug); 
            }
            Console.WriteLine("Total Found: " + buglist.Count);
            excelHelper.PrintToExcelFile(reboundDictionary);
        }

        private List<Issue> GetAllBugs()
        {
            //Tüm bugların toplanması
            var client = restHelper.GenerateClient();
            var request = restHelper.PrepareRequest("/rest/api/3/search?jql=project=TSI&type=Bug");

            IRestResponse response = client.Execute(request);
            var yalandan = JsonConvert.DeserializeObject<JiraItem>(response.Content);
            Console.WriteLine(reboundDictionary);

            return yalandan.issues.ToList();

        }



        /// <summary>
        /// Kaç kere Done durumundan In Progress'e çekilmiş
        /// </summary>
        /// <param name="transition"></param>
        /// <returns></returns>
        private int CalculateRebound(JiraChangeLog history)
        {
            //history.issues[0].changelog içinde loop 
            //item[1] içindeki fromString Done olup toString InProgress olanları

            return 0;
        }

        private JiraChangeLog GetHistory(string bugID)
        {
            var client = restHelper.GenerateClient();
            var request = restHelper.PrepareRequest("/rest/api/2/search?jql=key=" + bugID + "&expand=changelog");

            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<JiraChangeLog>(response.Content);
        }


    }
}
