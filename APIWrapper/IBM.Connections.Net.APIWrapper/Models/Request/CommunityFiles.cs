using IBM.Connections.Net.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IBM.Connections.Net.Api.Models.Request
{
   public class CommunityFiles : BaseRequest
   {
      public string CommunityId { get; set; }
      public bool? IncludePath { get; set; }

      public bool? acls { get; set; }

      public bool? includeQuota { get; set; }

      public bool? shared { get; set; }
      public bool? includetags { get; set; }
      public SortByValues? SortBy { get; set; }

      public string[] tag { get; set; }

      public VisibilityValues? visibility { get; set; }

      [ToMiliseconds]
      public DateTime? since { get; set; }




      public enum SortByValues
      {
         commented,
         downloaded,
         length,
         modified,
         published,
         recommended,
         title,
         updated
      }
      public enum VisibilityValues
      {
         @public,
         @private
      }
   }
}
