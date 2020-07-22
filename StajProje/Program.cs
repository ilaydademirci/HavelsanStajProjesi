using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class Program
    {
       public static void Main(string[] args)
        {
            //string url = @"https://temmuzhvlstaj.atlassian.net/1";
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(IEnumerable<RootObject>));
            //WebClient syncClient = new WebClient();
            //string content = syncClient.DownloadString(url);

            //using (MemoryStream memo = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            //{
            //    IEnumerable<RootObject> countries = (IEnumerable<RootObject>)serializer.ReadObject(memo);
            //}

            var client = new RestClient("https://temmuzhvlstaj.atlassian.net/rest/api/3/");
            var request = new RestRequest("issue/TSI-2", Method.GET);
            var queryResult = client.Execute<List<JiraItem>>(request).Data;

            Console.Read();
        }
    }
}
