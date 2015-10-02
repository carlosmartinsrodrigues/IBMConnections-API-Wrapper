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
      [TestMethod]
      public void TestGetMyActivityStream()
      {
         ConnectionsApiService connectionsApiService = getService();
         var response = connectionsApiService.ActivitiesService.GetMyActivityStream();
         Assert.IsNotNull(response);
         Assert.IsNotNull(response.Items);

         Assert.IsTrue(response.Items.Count > 1);

      }

      [TestMethod]
      public void TestSetStatusActivityStream()
      {
         ConnectionsApiService connectionsApiService = getService();
         var request = new IBM.Connections.Net.Api.Models.Request.UpdateStatus();
         request.content = System.DateTime.Now.ToString();
         var response = connectionsApiService.ActivitiesService.SetMyStatus(request);
         Assert.IsNotNull(response);
         Assert.IsNotNull(response.Items);

         Assert.IsTrue(response.Items.Count > 1);

      }
   }
}
