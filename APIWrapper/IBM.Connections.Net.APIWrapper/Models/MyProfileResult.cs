using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api.Models
{
    [XmlRoot(ElementName = "results")]
   public class MyProfileResult
   {
         
         [XmlElement(ElementName = "items")]
         public Items items { get; set; }
         [XmlAttribute(AttributeName = "pageSize")]
         public string PageSize { get; set; }
         [XmlAttribute(AttributeName = "searchType")]
         public string SearchType { get; set; }
         [XmlAttribute(AttributeName = "label")]
         public string Label { get; set; }
         [XmlAttribute(AttributeName = "totalSize")]
         public string TotalSize { get; set; }
         [XmlAttribute(AttributeName = "identifier")]
         public string Identifier { get; set; }
         [XmlAttribute(AttributeName = "page")]
         public string Page { get; set; }
         [XmlAttribute(AttributeName = "thr", Namespace = "http://www.w3.org/2000/xmlns/")]
         public string Thr { get; set; }
         [XmlAttribute(AttributeName = "opensearch", Namespace = "http://www.w3.org/2000/xmlns/")]
         public string Opensearch { get; set; }
         [XmlAttribute(AttributeName = "snx", Namespace = "http://www.w3.org/2000/xmlns/")]
         public string Snx { get; set; }
         [XmlAttribute(AttributeName = "td", Namespace = "http://www.w3.org/2000/xmlns/")]
         public string Td { get; set; }
         [XmlAttribute(AttributeName = "xmlns")]
         public string Xmlns { get; set; }


         [XmlRoot(ElementName = "folders")]
         public class Folders
         {
            [XmlElement(ElementName = "public")]
            public string Public { get; set; }
            [XmlElement(ElementName = "personal")]
            public string Personal { get; set; }
            [XmlElement(ElementName = "community")]
            public string Community { get; set; }
            [XmlElement(ElementName = "external")]
            public string External { get; set; }
            [XmlElement(ElementName = "internal")]
            public string Internal { get; set; }
         }

         [XmlRoot(ElementName = "person")]
         public class Person
         {
            [XmlElement(ElementName = "everyone")]
            public string Everyone { get; set; }
         }

         [XmlRoot(ElementName = "files")]
         public class Files
         {
            [XmlElement(ElementName = "public")]
            public string Public { get; set; }
            [XmlElement(ElementName = "personal")]
            public string Personal { get; set; }
            [XmlElement(ElementName = "community")]
            public string Community { get; set; }
            [XmlElement(ElementName = "external")]
            public string External { get; set; }
            [XmlElement(ElementName = "internal")]
            public string Internal { get; set; }
         }

         [XmlRoot(ElementName = "canView")]
         public class CanView
         {
            [XmlElement(ElementName = "groups")]
            public string Groups { get; set; }
            [XmlElement(ElementName = "communities")]
            public string Communities { get; set; }
            [XmlElement(ElementName = "activities")]
            public string Activities { get; set; }
            [XmlElement(ElementName = "folders")]
            public Folders Folders { get; set; }
            [XmlElement(ElementName = "person")]
            public Person Person { get; set; }
            [XmlElement(ElementName = "files")]
            public Files Files { get; set; }
         }

         [XmlRoot(ElementName = "canSync")]
         public class CanSync
         {
            [XmlElement(ElementName = "folders")]
            public Folders Folders { get; set; }
            [XmlElement(ElementName = "files")]
            public Files Files { get; set; }
         }

         [XmlRoot(ElementName = "canCreate")]
         public class CanCreate
         {
            [XmlElement(ElementName = "folders")]
            public Folders Folders { get; set; }
            [XmlElement(ElementName = "files")]
            public Files Files { get; set; }
         }

         [XmlRoot(ElementName = "capabilities")]
         public class Capabilities
         {
            [XmlElement(ElementName = "canView")]
            public CanView CanView { get; set; }
            [XmlElement(ElementName = "canSync")]
            public CanSync CanSync { get; set; }
            [XmlElement(ElementName = "canCreate")]
            public CanCreate CanCreate { get; set; }
         }

         [XmlRoot(ElementName = "resharing")]
         public class Resharing
         {
            [XmlAttribute(AttributeName = "defaultValue")]
            public string DefaultValue { get; set; }
            [XmlAttribute(AttributeName = "enabled")]
            public string Enabled { get; set; }
         }

         [XmlRoot(ElementName = "policy")]
         public class Policy
         {
            [XmlElement(ElementName = "capabilities")]
            public Capabilities Capabilities { get; set; }
            [XmlElement(ElementName = "resharing")]
            public Resharing Resharing { get; set; }
            [XmlAttribute(AttributeName = "maxFileSize")]
            public string MaxFileSize { get; set; }
            [XmlAttribute(AttributeName = "fileSyncEnabled")]
            public string FileSyncEnabled { get; set; }
            [XmlAttribute(AttributeName = "isExternalDefault")]
            public string IsExternalDefault { get; set; }
            [XmlAttribute(AttributeName = "isExternalEnabled")]
            public string IsExternalEnabled { get; set; }
            [XmlAttribute(AttributeName = "groupsEnabled")]
            public string GroupsEnabled { get; set; }
            [XmlAttribute(AttributeName = "simpleUploadMaxFileSize")]
            public string SimpleUploadMaxFileSize { get; set; }
            [XmlAttribute(AttributeName = "following")]
            public string Following { get; set; }
            [XmlAttribute(AttributeName = "contentFollowing")]
            public string ContentFollowing { get; set; }
            [XmlAttribute(AttributeName = "previewEnabled")]
            public string PreviewEnabled { get; set; }
            [XmlAttribute(AttributeName = "organizationPublic")]
            public string OrganizationPublic { get; set; }
            [XmlAttribute(AttributeName = "roundTripEditingEnabled")]
            public string RoundTripEditingEnabled { get; set; }
            [XmlAttribute(AttributeName = "subCollection")]
            public string SubCollection { get; set; }
         }

         [XmlRoot(ElementName = "fileSync")]
         public class FileSync
         {
            [XmlAttribute(AttributeName = "addOnPin")]
            public string AddOnPin { get; set; }
            [XmlAttribute(AttributeName = "addOnUploadPersonalFiles")]
            public string AddOnUploadPersonalFiles { get; set; }
         }

         [XmlRoot(ElementName = "preferences")]
         public class Preferences
         {
            [XmlElement(ElementName = "fileSync")]
            public FileSync FileSync { get; set; }
            [XmlAttribute(AttributeName = "pageSize")]
            public string PageSize { get; set; }
            [XmlAttribute(AttributeName = "defaultView")]
            public string DefaultView { get; set; }
            [XmlAttribute(AttributeName = "preferredColumns")]
            public string PreferredColumns { get; set; }
         }

         [XmlRoot(ElementName = "items")]
         public class Items
         {
            [XmlElement(ElementName = "policy")]
            public Policy Policy { get; set; }
            [XmlElement(ElementName = "preferences")]
            public Preferences Preferences { get; set; }
            [XmlElement(ElementName = "roles")]
            public List<string> Roles { get; set; }
            [XmlAttribute(AttributeName = "hasEmail")]
            public string HasEmail { get; set; }
            [XmlAttribute(AttributeName = "userType")]
            public string UserType { get; set; }
            [XmlAttribute(AttributeName = "userState")]
            public string UserState { get; set; }
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "hasPersonalPlace")]
            public string HasPersonalPlace { get; set; }
            [XmlAttribute(AttributeName = "nonce")]
            public string Nonce { get; set; }
            [XmlAttribute(AttributeName = "isExternal")]
            public string IsExternal { get; set; }
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "email")]
            public string Email { get; set; }
            [XmlAttribute(AttributeName = "photoURL")]
            public string PhotoURL { get; set; }
         }
     
   }

   
}
