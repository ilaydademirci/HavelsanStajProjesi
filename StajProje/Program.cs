using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class Program
    {
       public static void Main(string[] args)
        {
            string url = @"https://temmuzhvlstaj.atlassian.net/1";
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(IEnumerable<RootObject>));
            WebClient syncClient = new WebClient();
            string content = syncClient.DownloadString(url);

            using (MemoryStream memo = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                IEnumerable<RootObject> countries = (IEnumerable<RootObject>)serializer.ReadObject(memo);
            }

            Console.Read();
        }
    }
}
