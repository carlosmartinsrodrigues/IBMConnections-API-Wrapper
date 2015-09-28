using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using IBM.Connections.Net.Api.Models.Result;
namespace IBM.Connections.Net.Api.Models
{
   [XmlRoot(ElementName = "feed", Namespace = "http://www.w3.org/2005/Atom")]
   public class FilesResult
   {

      [XmlElement(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
      public Author author { get; set; }

      [XmlElement(ElementName = "collection", Namespace = "http://www.w3.org/2007/app")]
      public Collection collection { get; set; }


      //[XmlArray("entry")]
      [XmlArrayItem("entry", typeof(Entry))]
      public List<Entry> FilesEntry { get; set; }


      [XmlElement(ElementName = "generator", Namespace = "http://www.w3.org/2005/Atom")]
      public Generator generator { get; set; }
      [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
      public string Id { get; set; }
      [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
      public List<Link> link { get; set; }

      [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
      public Title title { get; set; }
      [XmlElement(ElementName = "totalResults", Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
      public int TotalResults { get; set; }
      [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
      public string Updated { get; set; }
      [XmlElement(ElementName = "uuid", Namespace = "urn:ibm.com/td")]
      public string Uuid { get; set; }


   }

}
