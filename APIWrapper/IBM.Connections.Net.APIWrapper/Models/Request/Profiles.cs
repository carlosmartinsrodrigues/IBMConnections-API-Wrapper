using IBM.Connections.Net.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBM.Connections.Net.Api.Models.Request
{
   public class Profiles : BaseRequest
   {
      public string connectionType { get { return "colleague"; } }


      public string email { get; set; }
      public bool? inclMessage { get; set; }
      public bool? inclUserStatus { get; set; }
      public string key { get; set; }
      public string userid { get; set; }
      public OutputType outputType { get; set; }
      public SortBy sortby { get; set; }
      public enum OutputType
      {
         connection,
         profile
      }
      public enum SortBy
      {
         displayName,
         modified
      }

   }
}
