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
         var server = "https://dubxpcvm1192.mul.ie.ibm.com:9444";
         var username = "ajones1";
         var password = "jones1";
         //hack for my dev environment
         System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
         //end hack for my dev env
         var client = new IBM.Connections.Net.Api.ConnectionsApiService(server,username,password);

            
         var result = client.ProfilesService.GetMyProfile();
         Console.WriteLine(result.items.Email);
         Console.ReadLine();
      
      }
   }
}
