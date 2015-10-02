using IBM.Connections.Net.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Connections.Net.Api.Helpers;
using IBM.Connections.Net.Api.Models.Result;
namespace IBM.Connections.Net.Api.Services
{
   public class ProfilesService
   {
      private readonly ConnectionsApiService _apiService;

      public ProfilesService(ConnectionsApiService currentInstance)
      {
         _apiService = currentInstance;
      }

      public MyProfileResult GetMyProfile()
      {
         string url = string.Format("/files/basic/api/people/feed?self=true&format=xml");

         return _apiService.Get<MyProfileResult>(url, null);
      }

   
      public ProfilesResult GetCollegues(IBM.Connections.Net.Api.Models.Request.Profiles request)
      {
         string url = string.Format("/profiles/atom2/forms/viewallfriends.xml");

         return _apiService.Get<ProfilesResult>(url, request.ToDictionary());
      }

      public ProfilesResult GetPeopleStatus(IBM.Connections.Net.Api.Models.Request.Status request)
      {
         string url = string.Format("/profiles/atom/mv/theboard/entries/related.do");

         return _apiService.Get<ProfilesResult>(url, request.ToDictionary());
      }

      public ProfilesResult GetPeopleFollowing(IBM.Connections.Net.Api.Models.Request.ProfilesFollow request)
      {

         string url = string.Format("/profiles/follow/atom/resources");

         return _apiService.Get<ProfilesResult>(url, request.ToDictionary());
      }

   }
}
