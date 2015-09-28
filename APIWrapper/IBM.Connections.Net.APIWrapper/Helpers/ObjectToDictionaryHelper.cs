using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Connections.Net.Api.Helpers;
namespace IBM.Connections.Net.Api.Helpers
{ 
      public static class ObjectToDictionaryHelper
      {
         public static Dictionary<string, string> ToDictionary(this object source)
         {
            return source.ToDictionary<object>();
         }

         public static Dictionary<string, string> ToDictionary<T>(this object source)
         {
            if (source == null)
               ThrowExceptionWhenSourceArgumentIsNull();

            var dictionary = new Dictionary<string, string>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
            {
               
                  AddPropertyToDictionary<T>(property, source, dictionary);
               
            }
            return dictionary;
         }

         private static void AddPropertyToDictionary<T>(PropertyDescriptor property, object source, Dictionary<string, string> dictionary)
         {
            object value = property.GetValue(source);
            if (IsExportable(property) && value!=null)
               dictionary.Add(property.Name, GetTranslatedValue<T>(property,value));
         }
         
         private static bool IsOfType<T>(object value)
         {
            return value is T;
         }
       
         private static bool IsExportable(PropertyDescriptor property)
         {
            NotExportedAttribute attr = property.Attributes[typeof(NotExportedAttribute)]
                                                          as NotExportedAttribute;

            return attr==null;
         }
         private static string GetTranslatedValue<T>(PropertyDescriptor property, object value)
         {
            if (value == null)
               return null;

            ToMilisecondsAttribute attr = property.Attributes[typeof(ToMilisecondsAttribute)] as ToMilisecondsAttribute;

            if (attr != null)
               return Extensions.GetDateAsLong(((DateTime)value)).ToString();
            else
               return ((T)value).ToString();
         }

         private static void ThrowExceptionWhenSourceArgumentIsNull()
         {
            throw new ArgumentNullException("source", "Unable to convert object to a dictionary. The source object is null.");
         }
      }
   
}
