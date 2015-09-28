using IBM.Connections.Net.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Settings
{
   public static class EnumExtensions
   {
      public static string GetValueAsString(this Helpers.Operation environment)
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
   }
}
