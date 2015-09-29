using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Api.Models
{
   public class AuthenticationResult
   {
      public AuthenticationResult()
      {
         Authenticated = false;
         UserID = string.Empty;
      }
      public AuthenticationResult(string userId,string email, string name)
      {
         Authenticated = !(string.IsNullOrEmpty(userId));
         UserID = userId;
         Email = email;
         Name = name;
      }
      public bool Authenticated { get; set; }
      public string UserID { get; set; }
      public string Email { get; set; }
      public string Name { get; set; }
   }
}
