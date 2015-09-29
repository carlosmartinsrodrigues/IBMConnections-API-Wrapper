using IBM.Connections.Net.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Tests
{
   public class BaseTest
   {
      //helper create service
      public ConnectionsApiService getService()
      {
         //hack for my dev environment
         System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
         //end hack for my dev env

         return new ConnectionsApiService("https://dubxpcvm1192.mul.ie.ibm.com:9444", "ajones1", "jones1");
        
      }
   }
}
