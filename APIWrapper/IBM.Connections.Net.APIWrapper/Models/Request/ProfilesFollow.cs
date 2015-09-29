using IBM.Connections.Net.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBM.Connections.Net.Api.Models.Request
{
   public class ProfilesFollow : BaseRequest
   {
      public Type type { get; set; }


      public Source source { get; set; }
      public bool? inclMessage { get; set; }
      public bool? inclUserStatus { get; set; }
      public enum Source
      {       
         connections,
         profiles
      }
      public enum Type
      {
         Profile,
         colleague
      }

   }
}
