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
      public ConnectionsApiService getService(bool? cloud = false)
      {
         return new ConnectionsApiService("https://dubxpcvm1192.mul.ie.ibm.com:9444", "ajones1", "jones1");
        
      }
   }
}
