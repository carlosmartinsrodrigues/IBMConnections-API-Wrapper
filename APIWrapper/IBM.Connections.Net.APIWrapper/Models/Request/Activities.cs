using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IBM.Connections.Net.Api.Models.Request
{
   public class Activities:BaseRequest
   {
      public string email { get; set; }
      public Priority priority { get; set; }
      public string search { get; set; }
      public SortOrder? sortOrder { get; set; }

      public enum SortOrder
      {
         asc,
         desc
      }
   }
}
