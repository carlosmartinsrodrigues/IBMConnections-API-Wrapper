using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Connections.Net.Settings.Helpers;
namespace IBM.Connections.Net.Settings
{
   public class ConnectionsServiceConfiguration
   {
      public string ServiceUrl { get; set; }
      public string User { get; set; }
      public string Email { get; set; }
      public string Name { get; set; }
      protected string UserId { get; set; }

      public void SetUserID(string userId){
         UserId=UserId;
      }
      public string GetUserID()
      {
         return UserId;
      }
       
      public string IntrospectionService { get { return "files/basic/api/introspection"; } }
      public string UserIntrospectionService { get { return "files/basic/api/people/feed?self=true&format=xml"; } }
      public string ConfigService { get { return "files/serviceconfigs"; } }
      public Dictionary<int, ServiceInfo> serviceInformation { get; set; }
      public Dictionary<ServiceType, Uri> serviceConfig { get; set; }
      public Dictionary<string, string> serviceOperations { get; set; }

      public string GetEndPoint(ServiceType type, Operation operation)
      {
         string endPoint = serviceConfig.ToList().Find(x => x.Key == type).Value.PathAndQuery.ToString().Replace(ServiceUrl, "") + operation.GetValueAsString();

         if (endPoint.IndexOf(Constants.userid) > 0)
            endPoint = endPoint.Replace(Constants.userid, UserId);

         return endPoint;
      }
    

   }
   public class ServiceInfo
   {
      public ServiceType Type { get; set; }
      public ServiceInfo(string title, string url, string type)
      {
         Title = title;
         URL = url;
         Type = ServiceInfo.GetServiceType(type);
      }
      public string Title;
      public string URL;

    
      
      public static ServiceType GetServiceType(string title)
      {
         ServiceType returnType = ServiceType.Unkown;
         switch (title)
         {
            case "Libraries":
               returnType = ServiceType.Libraries;
               break;
            case "Files":
               returnType = ServiceType.Files;
               break;
            case "Folders":
               returnType = ServiceType.Folders;
               break;
            case "Recycle Bin":
               returnType = ServiceType.RecycleBin;
               break;
            case "profiles":
               returnType = ServiceType.Profiles;
               break;
            case "microblogging":
               returnType = ServiceType.MicroBlogging;
               break;
            case "help":
               returnType = ServiceType.Help;
               break;
            case "wikis":
               returnType = ServiceType.Wikis;
               break;
            case "metrics":
               returnType = ServiceType.Metrics;
               break;
            case "sand":
               returnType = ServiceType.Sand;
               break;
            case "opengraph":
               returnType = ServiceType.Opengraph;
               break;
            case "personTag":
               returnType = ServiceType.PersonTag;
               break;
            case "pushnotification":
               returnType = ServiceType.PushNotification;
               break;
            case "ecm_files":
               returnType = ServiceType.ECMFiles;
               break;
            case "communities":
               returnType = ServiceType.Communities;
               break;

            case "oauthprovider":
               returnType = ServiceType.OauthProvider;
               break;
            case "mediaGallery":
               returnType = ServiceType.MediaGallery;
               break;
            case "webresources":
               returnType = ServiceType.WebResources;
               break;
            case "blogs":
               returnType = ServiceType.Blogs;
               break;
            case "news":
               returnType = ServiceType.News;
               break;
            case "people_finder":
               returnType = ServiceType.PeopleFinder;
               break;
            case "oauth":
               returnType = ServiceType.Oauth;
               break;
            case "dogear":
               returnType = ServiceType.Dogear;
               break;
            case "mobile":
               returnType = ServiceType.Mobile;
               break;
            case "bookmarklet":
               returnType = ServiceType.Bookmarklet;
               break;
            case "moderation":
               returnType = ServiceType.Moderation;
               break;
            case "deploymentConfig":
               returnType = ServiceType.DeploymentConfig;
               break;
            case "search":
               returnType = ServiceType.Search;
               break;
            case "activities":
               returnType = ServiceType.Activities;
               break;
            case "thumbnail":
               returnType = ServiceType.Thumbnail;
               break;
            case "homepage":
               returnType = ServiceType.Homepage;
               break;
            case "forums":
               returnType = ServiceType.Forums;
               break;
            case "cognos":
               returnType = ServiceType.Cognos;
               break;
            case "files":
               returnType = ServiceType.Files;
               break;
            case "opensocial":
               returnType = ServiceType.OpenSocial;
               break;
            case "bss":
               returnType = ServiceType.bss;
               break;
            case "scprofiles":
               returnType = ServiceType.scprofiles;               
               break;
            default:
               break;
         }
         return returnType;
      }
   }


}
