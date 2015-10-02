using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IBM.Connections.Net.Api.Models.Internal
{
   class UserCredentials
   {


      public UserCredentials(string username, string password)
      {
         this.Username = username;
         this.Password = password;
         this.Token = Base64Encode(string.Format("<credentials user='{0}' pass='{1}' />", username, password));
      }
      public UserCredentials(string token)
      {
         try
         {
            this.Token = token;
            XmlDocument doc = new XmlDocument();
            doc.InnerXml = Base64Decode(token);
            XmlNode credential = doc.SelectSingleNode("credentials");
            this.Username = credential.Attributes["user"].Value;
            this.Password = credential.Attributes["pass"].Value;
         }
         catch (System.Exception)
         {
            
         }
       
      }
      public string Username { get; set; }
      public string Password { get; set; }
      public string Token { get; set; }

      public static string Base64Encode(string plainText)
      {
         var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
         return System.Convert.ToBase64String(plainTextBytes);
      }
      public static string Base64Decode(string base64EncodedData)
      {
         var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
         return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
      }
   }
}
