using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Api.Models.Internal
{
   class UserCredentials
   {
     

      public UserCredentials(string username, string password)
      {
         this.Username = username;
         this.Password = password;
      }
      public string Username { get; set; }
      public string Password { get; set; }
   }
}
