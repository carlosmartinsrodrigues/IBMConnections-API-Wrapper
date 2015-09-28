using IBM.Connections.Net.Settings;
using IBM.Connections.Net.Settings.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Api.Helpers
{
   public static class Extensions
   {
      public static string GetValueAsString(this Operation environment)
      {
         // get the field 
         var field = environment.GetType().GetField(environment.ToString());
         var customAttributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

         if (customAttributes.Length > 0)
         {
            return (customAttributes[0] as DescriptionAttribute).Description;
         }
         else
         {
            return environment.ToString();
         }
      }

      public static long? GetDateAsLong(this DateTime? date)
      {

            if (date == null)
               return null;
            else
            {
               var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
               return Convert.ToInt64(((DateTime)date - epoch).TotalMilliseconds);
            }

      }
   }
}
