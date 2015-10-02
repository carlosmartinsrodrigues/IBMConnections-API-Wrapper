using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IBM.Connections.Net.Api;
using IBM.Connections.Net.Settings;
using IBM.Connections.Net.Api.Models.Result;
namespace IBM.Connections.Net.Tests
{
   [TestClass]
   public class ProfilesTest : BaseTest
   {
      [TestMethod]
      public void TestGetMyProfile()
      {

         ConnectionsApiService connectionsApiService = getService();
       
         var response = connectionsApiService.ProfilesService.GetMyProfile();
         Assert.IsNotNull(response);
         Assert.IsNotNull(response.items);
      }

      [TestMethod]
      public void TestGetMyFriends()
      {
      
         ConnectionsApiService connectionsApiService = getService();
         var request=new IBM.Connections.Net.Api.Models.Request.Profiles();
         request.key = connectionsApiService.UserID;
         var response = connectionsApiService.ProfilesService.GetCollegues(request);
         Assert.IsNotNull(response);
         int? expectedTotal = (response.TotalResults > request.pageSize ? request.pageSize : response.TotalResults);
         Assert.AreEqual(response.profiles.Count, expectedTotal);
      }

      [TestMethod]
      public void TestGetFollowing()
      {
         ConnectionsApiService connectionsApiService = getService();
         var request = new IBM.Connections.Net.Api.Models.Request.ProfilesFollow();
         request.page = 1;
         request.pageSize = 10;
         request.inclMessage = true;
         request.inclUserStatus = true;
         request.source = Api.Models.Request.ProfilesFollow.Source.profiles;
         request.type = Api.Models.Request.ProfilesFollow.Type.Profile; 
         var response = connectionsApiService.ProfilesService.GetPeopleFollowing(request);
         Assert.IsNotNull(response);
         int? expectedTotal = (response.TotalResults > request.pageSize ? request.pageSize : response.TotalResults);
         Assert.AreEqual(response.profiles.Count, expectedTotal);
      }

      [TestMethod]
      public void TestGetStatus()
      {
         ConnectionsApiService connectionsApiService = getService();

         var request = new IBM.Connections.Net.Api.Models.Request.ProfilesFollow();
         request.page = 1;
         request.pageSize = 10;
         request.inclMessage = true;
         request.inclUserStatus = true;
         request.source = Api.Models.Request.ProfilesFollow.Source.profiles;
         request.type = Api.Models.Request.ProfilesFollow.Type.Profile;
         var responseFollowing = connectionsApiService.ProfilesService.GetPeopleFollowing(request);

         var requestStatus = new IBM.Connections.Net.Api.Models.Request.Status();
         requestStatus.page = 1;
         requestStatus.pageSize = 10;
         requestStatus.email = responseFollowing.profiles[0].Email;
         var responseStatus = connectionsApiService.ProfilesService.GetPeopleStatus(requestStatus);
         Assert.IsNotNull(responseStatus);
         int? expectedTotal = (responseStatus.TotalResults > requestStatus.pageSize ? requestStatus.pageSize : responseStatus.TotalResults);
         Assert.AreEqual(responseStatus.profiles.Count, expectedTotal);
      }
     
   }
}
