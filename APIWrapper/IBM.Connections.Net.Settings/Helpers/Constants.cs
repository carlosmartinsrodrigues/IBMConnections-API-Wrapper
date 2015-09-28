using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Settings.Helpers
{
   public enum ServiceType
   {
      Libraries,
      Files,
      Folders,
      RecycleBin,
      Profiles,
      MicroBlogging,
      Help,
      Wikis,
      Metrics,
      Sand,
      Opengraph,
      Unkown,
      PersonTag,
      PushNotification,
      ECMFiles,
      Communities,
      OauthProvider,
      MediaGallery,
      WebResources,
      Blogs,
      News,
      PeopleFinder,
      Oauth,
      Dogear,
      Mobile,
      Bookmarklet,
      Moderation,
      DeploymentConfig,
      Search,
      Activities,
      Thumbnail,
      Homepage,
      Forums,
      Cognos,
      OpenSocial,
      bss,
      scprofiles
   }
   public enum Operation
   {
      [Description("/atom/profile.do?format=lite&output=vcard&outputType=profile&ps=100&userid={userid}")]
      PeopleFollowing,
      [Description("/atom/profile.do?email={email}")]
      SearchingPeople,
      [Description("/atom/mv/theboard/entries/related.do?email={email}")]
      StatusMessage

   }

   public static class Constants
   {

      public static string userid = "{userid}";


   }
}
