using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models
{
   public class ActivitiesEntry : BaseEntry
   {
      [XmlElement(ElementName = "contributor", Namespace = "http://www.w3.org/2005/Atom")]
      public Member Contributor { get; set; }
      [XmlElement(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
      public List<Category> Category { get; set; }
      [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
      public List<Link> Link { get; set; }
      [XmlElement(ElementName = "collection", Namespace = "http://www.w3.org/2007/app")]
      public String Collection { get; set; }
      [XmlElement(ElementName = "activity", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string Activity { get; set; }
      [XmlElement(ElementName = "position", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string Position { get; set; }
      [XmlElement(ElementName = "depth", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string Depth { get; set; }
      [XmlElement(ElementName = "permissions", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string Permissions { get; set; }
      [XmlElement(ElementName = "icon", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string Icon { get; set; }
      [XmlElement(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
      public String Content { get; set; }
      [XmlElement(ElementName = "commUuid", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string CommUuid { get; set; }
      [XmlElement(ElementName = "communityUuid", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string CommunityUuid { get; set; }
      [XmlElement(ElementName = "communityName", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public String CommunityName { get; set; }
      [XmlElement(ElementName = "themeId", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string ThemeId { get; set; }
      [XmlElement(ElementName = "duedate", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string Duedate { get; set; }
   }
}
