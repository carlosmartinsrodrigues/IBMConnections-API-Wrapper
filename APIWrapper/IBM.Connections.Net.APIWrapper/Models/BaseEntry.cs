using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models
{
   public class BaseEntry
   {
      [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
      public string Id { get; set; }

      [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
      public String Title { get; set; }

      [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
      public string Updated { get; set; }

      [XmlElement(ElementName = "published", Namespace = "http://www.w3.org/2005/Atom")]
      public string Published { get; set; }

      [XmlElement(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
      public Member Author { get; set; }
   }
}
