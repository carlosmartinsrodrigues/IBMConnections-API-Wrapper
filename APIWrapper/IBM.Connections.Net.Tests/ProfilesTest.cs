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
         var request = new IBM.Connections.Net.Api.Models.Request.Profiles();
         request.page = 1;
         request.pageSize = 10;
         request.inclMessage = true;
         request.inclUserStatus = true;
         request.outputType = Api.Models.Request.Profiles.OutputType.profile;
         var response = connectionsApiService.ProfilesService.GetPeopleFollowing(request);
         Assert.IsNotNull(response);
         int? expectedTotal = (response.TotalResults > request.pageSize ? request.pageSize : response.TotalResults);
         Assert.AreEqual(response.profiles.Count, expectedTotal);
      }

      [TestMethod]
      public void TestGetStatus()
      {
         ConnectionsApiService connectionsApiService = getService();
         var request = new IBM.Connections.Net.Api.Models.Request.Status();
         request.page = 1;
         request.pageSize = 10;
         var response = connectionsApiService.ProfilesService.GetPeopleStatus(request);
         Assert.IsNotNull(response);
         int? expectedTotal = (response.TotalResults > request.pageSize ? request.pageSize : response.TotalResults);
         Assert.AreEqual(response.profiles.Count, expectedTotal);
      }
   }
}
