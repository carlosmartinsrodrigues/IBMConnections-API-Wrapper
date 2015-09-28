using IBM.Connections.Net.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IBM.Connections.Net.Api.Models.Request
{
   public class FilesShared : BaseRequest
   {
      public bool? IncludePath { get; set; }
      public Direction direction { get; set; }

      public SortByValues? SortBy { get; set; }

      public string[] tag { get; set; }

      public VisibilityValues? visibility { get; set; }



      public enum Direction
      {
         inbound,
         outbound
      }

      public enum SortByValues
      {
         author,
         created,
         createdBy,
         published,
         sharedBy,
         sharedWith,
         commented,
         downloaded,
         label,
         length,
         modified,
         recommended,
         title,
         totalMediaSize,
         updated  
      }
      public enum VisibilityValues
      {
         @public,
         @private
      }
   }
}
