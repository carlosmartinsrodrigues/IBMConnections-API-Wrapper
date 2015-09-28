using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBM.Connections.Net.Api.Helpers
{
   class NotExportedAttribute : Attribute
   {
      public bool exportable { get { return false; } }
   }
}
