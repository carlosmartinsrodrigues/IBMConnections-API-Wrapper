using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models
{
   public class Activities : Feed
   {
       [XmlElement(ElementName = "author")]
      public Member author { get; set; }

      [XmlArray("entry")]
      [XmlArrayItem("entry")]
      public List<ActivitiesEntry> activities { get; set; }
     
   }
}
