using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models.Result
{
   [XmlRoot(ElementName = "items")]
   public class UserServiceIntrospection
   {
      public string name { get; set; }
      public string id { get; set; }
      public string email { get; set; }
   }
}
