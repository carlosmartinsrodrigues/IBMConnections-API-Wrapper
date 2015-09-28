using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models.Result
{
   [XmlRoot(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
   public class Author
   {
      [XmlElement(ElementName = "email", Namespace = "http://www.w3.org/2005/Atom")]
      public string Email { get; set; }
      [XmlElement(ElementName = "name", Namespace = "http://www.w3.org/2005/Atom")]
      public string Name { get; set; }
      [XmlElement(ElementName = "userid", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string Userid { get; set; }
      [XmlElement(ElementName = "userState", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string UserState { get; set; }
   }

   [XmlRoot(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
   public class Category
   {
      [XmlAttribute(AttributeName = "label")]
      public string Label { get; set; }
      [XmlAttribute(AttributeName = "scheme")]
      public string Scheme { get; set; }
      [XmlAttribute(AttributeName = "term")]
      public string Term { get; set; }
   }

   public class Collection
   {

      [XmlArrayItem("accept", Namespace = "http://www.w3.org/2007/app")]
      public List<string> Accept { get; set; }
      [XmlAttribute(AttributeName = "app", Namespace = "http://www.w3.org/2000/xmlns/")]
      public string App { get; set; }
      [XmlAttribute(AttributeName = "href")]
      public string Href { get; set; }
      [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
      public Title Title { get; set; }
   }

   [XmlRoot(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
   public class Content
   {
      [XmlAttribute(AttributeName = "src")]
      public string Src { get; set; }
      [XmlAttribute(AttributeName = "type")]
      public string Type { get; set; }
   }

   public class Entry
   {

      public string Id { get; set; }
      public string Label { get; set; }
      public DateTime Modified { get; set; }
      [XmlElement(ElementName = "uuid", Namespace = "urn:ibm.com/td")]
      public string Uuid { get; set; }

      /// <summary>
      /// 
      /// </summary>
      [XmlElement(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
      public Author Author { get; set; }
      [XmlElement(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
      public Category Category { get; set; }
      [XmlElement(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
      public Content Content { get; set; }
      [XmlElement(ElementName = "created", Namespace = "urn:ibm.com/td")]
      public string Created { get; set; }



      [XmlElement(ElementName = "isExternal", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public List<string> IsExternal { get; set; }
      [XmlElement(ElementName = "isSyncable", Namespace = "urn:ibm.com/td")]
      public string IsSyncable { get; set; }

      [XmlElement(ElementName = "lastAccessed", Namespace = "urn:ibm.com/td")]
      public string LastAccessed { get; set; }
      [XmlElement(ElementName = "libraryId", Namespace = "urn:ibm.com/td")]
      public string LibraryId { get; set; }
      [XmlElement(ElementName = "libraryType", Namespace = "urn:ibm.com/td")]
      public string LibraryType { get; set; }

      [XmlArrayItem("link", typeof(Link))]
      public List<Link> FileLinks { get; set; }

      [XmlElement(ElementName = "lock", Namespace = "urn:ibm.com/td")]
      public Lock Lock { get; set; }

      [XmlElement(ElementName = "modifier", Namespace = "urn:ibm.com/td")]
      public Modifier Modifier { get; set; }
      [XmlElement(ElementName = "objectTypeName", Namespace = "urn:ibm.com/td")]
      public string ObjectTypeName { get; set; }
      [XmlElement(ElementName = "propagation", Namespace = "urn:ibm.com/td")]
      public string Propagation { get; set; }
      [XmlElement(ElementName = "published", Namespace = "http://www.w3.org/2005/Atom")]
      public string Published { get; set; }
      [XmlElement(ElementName = "rank", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public List<Rank> Rank { get; set; }
      [XmlElement(ElementName = "restrictedVisibility", Namespace = "urn:ibm.com/td")]
      public string RestrictedVisibility { get; set; }
      [XmlElement(ElementName = "summary", Namespace = "http://www.w3.org/2005/Atom")]
      public Summary Summary { get; set; }
      [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
      public Title Title { get; set; }
      [XmlElement(ElementName = "totalMediaSize", Namespace = "urn:ibm.com/td")]
      public string TotalMediaSize { get; set; }
      [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
      public string Updated { get; set; }

      [XmlElement(ElementName = "versionLabel", Namespace = "urn:ibm.com/td")]
      public string VersionLabel { get; set; }
      [XmlElement(ElementName = "versionUuid", Namespace = "urn:ibm.com/td")]
      public string VersionUuid { get; set; }
      [XmlElement(ElementName = "visibility", Namespace = "urn:ibm.com/td")]
      public string Visibility { get; set; }
   }


  
   [XmlRoot(ElementName = "generator", Namespace = "http://www.w3.org/2005/Atom")]
   public class Generator
   {
      [XmlText]
      public string Text { get; set; }
      [XmlAttribute(AttributeName = "uri")]
      public string Uri { get; set; }
      [XmlAttribute(AttributeName = "version")]
      public string Version { get; set; }
   }

   [XmlRoot(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
   public class Link
   {
      [XmlAttribute(AttributeName = "count", Namespace = "http://purl.org/syndication/thread/1.0")]
      public string Count { get; set; }
      [XmlAttribute(AttributeName = "href")]
      public string Href { get; set; }
      [XmlAttribute(AttributeName = "hreflang")]
      public string Hreflang { get; set; }
      [XmlAttribute(AttributeName = "length")]
      public string Length { get; set; }
      [XmlAttribute(AttributeName = "rel")]
      public string Rel { get; set; }
      [XmlAttribute(AttributeName = "thr", Namespace = "http://www.w3.org/2000/xmlns/")]
      public string Thr { get; set; }
      [XmlAttribute(AttributeName = "title")]
      public string Title { get; set; }
      [XmlAttribute(AttributeName = "type")]
      public string Type { get; set; }
   }

   [XmlRoot(ElementName = "lock", Namespace = "urn:ibm.com/td")]
   public class Lock
   {
      [XmlAttribute(AttributeName = "type")]
      public string Type { get; set; }
   }

   [XmlRoot(ElementName = "modifier", Namespace = "urn:ibm.com/td")]
   public class Modifier
   {
      [XmlElement(ElementName = "email", Namespace = "http://www.w3.org/2005/Atom")]
      public string Email { get; set; }
      [XmlElement(ElementName = "name", Namespace = "http://www.w3.org/2005/Atom")]
      public string Name { get; set; }
      [XmlElement(ElementName = "userid", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string Userid { get; set; }
      [XmlElement(ElementName = "userState", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string UserState { get; set; }
   }

   [XmlRoot(ElementName = "rank", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
   public class Rank
   {
      [XmlAttribute(AttributeName = "scheme")]
      public string Scheme { get; set; }
      [XmlText]
      public string Text { get; set; }
   }

   [XmlRoot(ElementName = "summary", Namespace = "http://www.w3.org/2005/Atom")]
   public class Summary
   {
      [XmlAttribute(AttributeName = "type")]
      public string Type { get; set; }
   }

   [XmlRoot(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
   public class Title
   {
      [XmlText]
      public string Text { get; set; }
      [XmlAttribute(AttributeName = "type")]
      public string Type { get; set; }
   }
}
