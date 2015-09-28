using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IBM.Connections.Net.Api;
using IBM.Connections.Net.Settings;
using IBM.Connections.Net.Api.Models.Result;
using IBM.Connections.Net.Api.Models;
namespace IBM.Connections.Net.Tests
{
   [TestClass]
   public class FilesTest : BaseTest
   {
     
      [TestMethod]
      public void TestGetMyFiles()
      {
         ConnectionsApiService connectionsApiService = getService();
         IBM.Connections.Net.Api.Models.Request.Files request = new IBM.Connections.Net.Api.Models.Request.Files();
         //request.page = 1;
         //request.pageSize = 10;
         //request.IncludePath = true;

         //request.since = DateTime.Now.AddDays(-5);
         var response = connectionsApiService.FilesService.GetMyFiles(request);
         Assert.IsNotNull(response);
         Assert.Inconclusive(response.FilesEntry.Count.ToString());
      }

      [TestMethod]
      public void TestDownloadFile()
      {
         ConnectionsApiService connectionsApiService = getService();
         IBM.Connections.Net.Api.Models.Request.Files request = new IBM.Connections.Net.Api.Models.Request.Files();
         request.page = 1;
         request.pageSize = 10;
         request.Filter = new string[] { "docx" };
         FilesResult response = connectionsApiService.FilesService.GetMyFiles(request);
         Assert.IsNotNull(response.TotalResults);
         Assert.IsTrue(response.TotalResults >= response.FilesEntry.Count);

      }
   
   }
}
