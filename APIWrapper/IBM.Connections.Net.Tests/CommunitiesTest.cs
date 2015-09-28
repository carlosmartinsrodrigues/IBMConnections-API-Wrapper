using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IBM.Connections.Net.Api;
using IBM.Connections.Net.Settings;
using IBM.Connections.Net.Api.Models.Result;
namespace IBM.Connections.Net.Tests
{
   [TestClass]
   public class CommunitiesTest : BaseTest
   {
   
      [TestMethod]
      public void TestGetMyCommunities()
      {
         ConnectionsApiService connectionsApiService = getService();
         var request=new IBM.Connections.Net.Api.Models.Request.Communities();
         request.page=1;
         request.pageSize=10;
         var response = connectionsApiService.CommunitiesService.GetMyCommunities(request);
         Assert.IsNotNull(response);
         int? expectedTotal = (response.TotalResults > request.pageSize ? request.pageSize : response.TotalResults);
         Assert.AreEqual(response.CommunityEntry.Count, expectedTotal);
      }

    
   }
}
