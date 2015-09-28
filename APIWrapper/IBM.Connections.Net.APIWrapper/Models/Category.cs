using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models
{
   [XmlRoot(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
   public class Category
   {
      [XmlAttribute(AttributeName = "scheme")]
      public string Scheme { get; set; }
      [XmlAttribute(AttributeName = "term")]
      public string Term { get; set; }
      [XmlAttribute(AttributeName = "label")]
      public string Label { get; set; }
   }
}
