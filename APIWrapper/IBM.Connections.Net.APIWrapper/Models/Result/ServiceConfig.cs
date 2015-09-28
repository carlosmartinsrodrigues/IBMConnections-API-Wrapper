using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models.Result
{
   [XmlRoot(ElementName = "feed")]
   public class ServiceConfig : BaseResponse
   {
      public string userid { get; set; }
      public DateTime Updated { get; set; }
      public string Title { get; set; }
      public string version { get; set; }

      [XmlArray("entry")]
      [XmlArrayItem("entry")]
      public List<Entry> configEntry { get; set; }
      

      public class Entry
      {
         public string id { get; set; }
         public string title { get; set; }
         [XmlArray("link")]
         [XmlArrayItem("link")]
         public List<link> linkEntry { get; set; }

         public class link
         {
            public string href { get; set; }
            public string rel { get; set; }
            public string type { get; set; }

         }
      }


      
   }

}
