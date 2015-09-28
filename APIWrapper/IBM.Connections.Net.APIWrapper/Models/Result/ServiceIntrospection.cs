using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models.Result
{
   [XmlRoot(ElementName = "service")]
   public class ServiceIntrospection : BaseResponse
   {
      public List<Workspace> app_workspace { get; set; }
      public Operations operations { get; set; }
     
      public class Workspace
      {
         public string title { get; set; }

         public List<Collection> app_collection { get; set; }


         public class Collection
         {
            //  [XmlAttribute("href")]
            public string href { get; set; }

            public string title { get; set; }

         }
      }
      public class Operations
      {
         public List<Operation> snx_operations { get; set; }
         public class Operation
         {
            public string id { get; set; }

            public string template { get; set; }

         }
      }
   }
}
