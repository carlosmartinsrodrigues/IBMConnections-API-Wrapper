using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.ConsoleApplication
{
   class Program
   {
      static void Main(string[] args)
      {

         string serverUrl, serviceUrl;
         serverUrl = "https://dubxpcvm1192.mul.ie.ibm.com:9444";
         serviceUrl = "/profiles/atom/profileEntry.do";
         var client = new RestClient(serverUrl);
         client.Authenticator = new HttpBasicAuthenticator("Ajones1", "jones1");
         var request = new RestRequest(serviceUrl, Method.GET);
         var response = client.Execute(request);
         Console.WriteLine(response.Content);
         Console.ReadLine();
      }
   }
}
