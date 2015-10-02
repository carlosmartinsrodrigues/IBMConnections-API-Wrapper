using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models
{
   public class ActivityStream 
   {
      [XmlRoot(ElementName = "summary", Namespace = "http://www.w3.org/2005/Atom")]
      public class Summary
      {
         [XmlAttribute(AttributeName = "type")]
         public string Type { get; set; }
         [XmlText]
         public string Text { get; set; }
      }

      [XmlRoot(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
      public class AuthorInformation
      {
         [XmlElement(ElementName = "name", Namespace = "http://www.w3.org/2005/Atom")]
         public string Name { get; set; }
      }

      [XmlRoot(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
      public class LinkInformation
      {
         [XmlAttribute(AttributeName = "rel")]
         public string Rel { get; set; }
         [XmlAttribute(AttributeName = "href")]
         public string Href { get; set; }
      }

      [XmlRoot(ElementName = "entry", Namespace = "http://www.w3.org/2005/Atom")]
      public class Entry
      {
         [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
         public string Id { get; set; }
         [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
         public string Title { get; set; }
         [XmlElement(ElementName = "summary", Namespace = "http://www.w3.org/2005/Atom")]
         public Summary Summary { get; set; }
         [XmlElement(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
         public AuthorInformation Author { get; set; }
         [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
         public string Updated { get; set; }
         [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
         public LinkInformation Link { get; set; }
      }

         [XmlArray("entry")]
         public List<Entry> Items { get; set; }
         [XmlElement(ElementName = "startIndex", Namespace = "http://a9.com/-/spec/opensearch/1.1")]
         public string StartIndex { get; set; }
         [XmlElement(ElementName = "totalResults", Namespace = "http://a9.com/-/spec/opensearch/1.1")]
         public string TotalResults { get; set; }
         [XmlElement(ElementName = "itemsPerPage", Namespace = "http://a9.com/-/spec/opensearch/1.1")]
         public string ItemsPerPage { get; set; }
         [XmlElement(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
         public string Author { get; set; }
         [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
         public string Title { get; set; }
         [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
         public string Updated { get; set; }
         [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
         public string Id { get; set; }
         [XmlAttribute(AttributeName = "osearch", Namespace = "http://www.w3.org/2000/xmlns/")]
         public string Osearch { get; set; }
         [XmlAttribute(AttributeName = "xmlns")]
         public string Xmlns { get; set; }

     
   }
}
