using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IBM.Connections.Net.Api;
using IBM.Connections.Net.Settings;
using IBM.Connections.Net.Api.Models.Result;
namespace IBM.Connections.Net.Tests
{
   [TestClass]
   public class ActivitiesTest : BaseTest
   {
   
      [TestMethod]
      public void TestGetMyActivities()
      {
         ConnectionsApiService connectionsApiService = getService();
         var response = connectionsApiService.ActivitiesService.GetMyActivities(new IBM.Connections.Net.Api.Models.Request.Activities());
         Assert.IsNotNull(response);
      }

      [TestMethod]
      public void TestGetMyActivitiesCompleted()
      {
         ConnectionsApiService connectionsApiService = getService();
         var response = connectionsApiService.ActivitiesService.GetCompleted(new IBM.Connections.Net.Api.Models.Request.Activities());
         Assert.IsNotNull(response);
      }
   }
}
