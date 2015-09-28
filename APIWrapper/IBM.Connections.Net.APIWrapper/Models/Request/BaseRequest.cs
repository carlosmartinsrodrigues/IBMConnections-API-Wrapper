using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Api.Models.Request
{
   public class BaseRequest
   {      
      public int?  page { get; set; }
      public int? pageSize { get; set; }
     
      public SortOrder? sortOrder { get; set; }
   }
}
