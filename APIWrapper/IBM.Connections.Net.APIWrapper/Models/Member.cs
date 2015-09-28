using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models
{
   
   public class Member
   {
      [XmlElement(ElementName = "name", Namespace = "http://www.w3.org/2005/Atom")]
      public string Name { get; set; }
      [XmlElement(ElementName = "email", Namespace = "http://www.w3.org/2005/Atom")]
      public string Email { get; set; }
      [XmlElement(ElementName = "userid", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string Userid { get; set; }
      [XmlElement(ElementName = "userState", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string UserState { get; set; }
      [XmlElement(ElementName = "isExternal", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string IsExternal { get; set; }
      [XmlElement(ElementName = "defaultMemberRole", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string DefaultMemberRole { get; set; }
      [XmlElement(ElementName = "ldapid", Namespace = "http://www.ibm.com/xmlns/prod/sn")]
      public string Ldapid { get; set; }
   }

   
}
