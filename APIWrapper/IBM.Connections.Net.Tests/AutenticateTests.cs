using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IBM.Connections.Net.Api;
using IBM.Connections.Net.Settings;
using IBM.Connections.Net.Api.Models.Result;
using IBM.Connections.Net.Api.Exception;
namespace IBM.Connections.Net.Tests
{
   [TestClass]
   public class AutenticateTests : BaseTest
   {
   
      [TestMethod]
      public void TestAuthenticate()
      {
      
         ConnectionsApiService connectionsApiService = getService();

         try
         {
            var response = connectionsApiService.AuthenticationService.Authenticate("ajones1", "jones1");
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.UserID);
         }
         catch (ConnectionsException ex)
         {
            Assert.Inconclusive("Failed Login");
         }
        
      }

   }
}
