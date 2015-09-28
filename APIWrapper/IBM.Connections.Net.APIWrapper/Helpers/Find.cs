using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Api.Helpers
{
   public class Find
   {
      public static bool EndsWithAny(string s, params string[] chars)
      {
         if (chars.Length == 0)
            return true;

         foreach (String c in chars)
         {
            if (s.EndsWith(c.ToString()))
               return true;
         }
         return false;
      }
   }
}
