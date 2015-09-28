using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models
{
   [XmlRoot(ElementName = "feed")]
   public class ProfilesResult : BaseResponse
   {
      public string Id { get; set; }
      public DateTime Updated { get; set; }
      public string Title { get; set; }
      public int TotalResults { get; set; }
      public int StartIndex { get; set; }
      public int ItemsPerPage { get; set; }

      [XmlArray("entry")]
      [XmlArrayItem("entry")]
      public List<Entry> profiles { get; set; }

      public class Entry
      {
        // public Entry() { }

         public string Id { get; set; }
         public string Title { get; set; }
         public DateTime Updated { get; set; }

         public string Name { get; set; }
         public string UserId { get; set; }
         public string Email { get; set; }
         public string userState { get; set; }
         public Boolean IsExternal { get; set; }
      }
   }

   
}
