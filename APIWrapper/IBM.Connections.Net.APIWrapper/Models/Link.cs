using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models
{

   public class Link
   {
      [XmlAttribute(AttributeName = "rel")]
      public string Rel { get; set; }
      [XmlAttribute(AttributeName = "href")]
      public string Href { get; set; }
      [XmlAttribute(AttributeName = "type")]
      public string Type { get; set; }
   }
}
