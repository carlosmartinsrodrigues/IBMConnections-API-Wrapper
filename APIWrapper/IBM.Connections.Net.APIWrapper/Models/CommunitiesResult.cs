using IBM.Connections.Net.Api.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models
{
   public class CommunitiesResult : Feed
   {
      //[XmlArray("entry")]
      [XmlArrayItem("entry")]
      public List<Entry> CommunityEntry { get; set; }

      public class Entry
      {
         [XmlElement(ElementName = "communityUuid", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
         public string CommunityUuid { get; set; }
         [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
         public string Id { get; set; }
         [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
         public string Title { get; set; }
         [XmlElement(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
         public List<Category> Category { get; set; }
         [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
         public List<Link> Link { get; set; }
         [XmlElement(ElementName = "membercount", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
         public string Membercount { get; set; }
         [XmlElement(ElementName = "communityType", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
         public string CommunityType { get; set; }
         [XmlElement(ElementName = "listWhenRestricted", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
         public string ListWhenRestricted { get; set; }
         [XmlElement(ElementName = "orgId", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
         public string OrgId { get; set; }
         [XmlElement(ElementName = "handle", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
         public string Handle { get; set; }
         [XmlElement(ElementName = "preModeration", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
         public string PreModeration { get; set; }
         [XmlElement(ElementName = "postModeration", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
         public string PostModeration { get; set; }
         [XmlElement(ElementName = "published", Namespace = "http://www.w3.org/2005/Atom")]
         public string Published { get; set; }
         [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
         public string Updated { get; set; }
         [XmlElement(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
         public Content Content { get; set; }
         [XmlElement(ElementName = "summary", Namespace = "http://www.w3.org/2005/Atom")]
         public Summary Summary { get; set; }
         [XmlElement(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
         public Author Author { get; set; }
         [XmlElement(ElementName = "contributor", Namespace = "http://www.w3.org/2005/Atom")]
         public Author Contributor { get; set; }
        
         [XmlElement(ElementName = "communityStartPage", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
         public string CommunityStartPage { get; set; }
         [XmlElement(ElementName = "isExternal", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
         public string IsExternal { get; set; }
         [XmlElement(ElementName = "memberEmailPrivileges", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
         public string MemberEmailPrivileges { get; set; }
      }


   }

}
