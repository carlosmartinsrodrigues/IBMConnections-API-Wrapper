using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Api.Models.Internal
{
    [DeserializeAs(Name = "AuthEndpointInfo")]
   class TokenResult
   {
      public string version { get; set; }
       public string user { get; set; }
       public string url { get; set; }
   }
}
