using IBM.Connections.Net.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBM.Connections.Net.Api.Models.Request
{
   public class Communities : BaseRequest
   {
      public string email { get; set; }
      public string search { get; set; }
      [ToMiliseconds]
      public DateTime since { get; set; }
      public string tag { get; set; }
      public string userid { get; set; }
      public enum SortBy
      {
         count,
         modified,
         title
      }


   }
}
