using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Atlassian;

namespace StajProje
{
    public class Program
    {
        public static void Main(string[] args)
        {
            JiraHelper helper = new JiraHelper();
            helper.CheckJira(); 
        }  
    } 
}