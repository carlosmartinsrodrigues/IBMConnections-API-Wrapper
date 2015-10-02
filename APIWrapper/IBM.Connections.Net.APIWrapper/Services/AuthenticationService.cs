using IBM.Connections.Net.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Connections.Net.Api.Helpers;
using IBM.Connections.Net.Api.Models.Result;
using RestSharp.Authenticators;
namespace IBM.Connections.Net.Api.Services
{
   public class AuthenticationService
   {
      private readonly ConnectionsApiService _apiService;

      public AuthenticationService(ConnectionsApiService currentInstance)
      {
         _apiService = currentInstance;
      }


      public AuthenticationResult Authenticate(string username, string password)
      {
         string url = string.Format("files/basic/api/people/feed?self=true&format=xml");
         IBM.Connections.Net.Api.Models.Internal.UserCredentials request = new Models.Internal.UserCredentials(username, password);
         UserServiceIntrospection result = _apiService.Get<UserServiceIntrospection>(url, request.ToDictionary());
         if (result == null)
            return new AuthenticationResult();
         else
            return new AuthenticationResult(result.id, result.email, result.name, request.Token);
      }


   }
}
