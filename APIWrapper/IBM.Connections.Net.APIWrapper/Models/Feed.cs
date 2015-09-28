using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models
{
   [XmlRoot(ElementName = "feed", Namespace = "http://www.w3.org/2005/Atom")]
   public class Feed
   {

      [XmlElement(ElementName = "icon", Namespace = "http://www.w3.org/2005/Atom")]
      public string Icon { get; set; }
      [XmlElement(ElementName = "logo", Namespace = "http://www.w3.org/2005/Atom")]
      public string Logo { get; set; }
      [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
      public string Id { get; set; }
      [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
      public String Title { get; set; }
      [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
      public string Updated { get; set; }
     
      [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
      public List<Link> Link { get; set; }
      [XmlElement(ElementName = "totalResults", Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
      public int TotalResults { get; set; }
      [XmlElement(ElementName = "startIndex", Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
      public int StartIndex { get; set; }
   
   }
}
