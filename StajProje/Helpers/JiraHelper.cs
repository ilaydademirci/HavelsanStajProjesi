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
        public ExcelHelper excelHelper = new ExcelHelper();
        public Dictionary<string, int> reboundDictionary = new Dictionary<string, int>();


        /// <summary>
        /// 
        /// </summary>
        /// 
        public void CheckJira()
        {
            var buglist = getAllBugs();

            foreach (JiraItem bug in buglist)
            {
                var bugTransition = getTransitions(bug.Key); //TSI-2
                int reboundCount = calculateRebound(bugTransition);
                reboundDictionary.Add(bug.Key, reboundCount);
            }

            excelHelper.PrintToExcelFile(reboundDictionary);
        }

        private List<JiraItem> getAllBugs()
        {
            //Tüm bugların toplanması
            return null;
        }

         

        /// <summary>
        /// Kaç kere Done durumundan In Progress'e çekilmiş
        /// </summary>
        /// <param name="transition"></param>
        /// <returns></returns>
        private int calculateRebound(JiraTransition transition)
        {
            return 0;
        }

        private JiraTransition getTransitions(string bugID)
        {
            var client = restHelper.GenerateClient();
            var request = restHelper.PrepareRequest("/rest/api/3/issue/" + bugID + "/transitions");

            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<JiraTransition>(response.Content);
        }


    }
}
