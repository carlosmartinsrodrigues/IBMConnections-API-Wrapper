using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Api.Helpers
{
    class GetHelpers
    {
        public static string GetXML(string url)
        {
           var client = new RestSharp.RestClient(url);
           client.Authenticator = new HttpBasicAuthenticator("UserA", "123");
           var request = new RestRequest(url, Method.GET);
           // execute the request
           IRestResponse response = client.Execute(request);
           var content = response.Content; // raw content as string
           return content;
        }
    }
   
}
