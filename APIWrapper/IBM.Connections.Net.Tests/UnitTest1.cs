using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IBM.Connections.Net.Api;
using IBM.Connections.Net.Settings;
using IBM.Connections.Net.Api.Models.Result;
namespace IBM.Connections.Net.Tests
{
   [TestClass]
   public class UnitTest1
   {
      //helper create service
      public ConnectionsApiService getService(bool? cloud=false)
      {
         if (cloud==null || cloud==false)
            return new ConnectionsApiService("https://connections.swg.usma.ibm.com", "carlosro@ie.ibm.com", "m4d3v$t23");
         else
            return new ConnectionsApiService("https://apps.na.collabserv.com", "carlosro@ie.ibm.com", "m4d3v$t23",true);
      }

      [TestMethod]
      public void TestPing()
      {
         ConnectionsApiService connectionsApiService = getService();

         var response = connectionsApiService.PingServer();
         Console.WriteLine(response.RawResponse);
         Assert.AreEqual(true, response.IsSuccesful);
      }
      [TestMethod]
      public void TestGetServerIntrospection()
      {
         ConnectionsApiService connectionsApiService = getService();

         Assert.IsTrue(connectionsApiService.GetConfig() != null);
         Assert.IsTrue(connectionsApiService.GetConfig().ConfigService.Length > 0);
      }

      [TestMethod]
      public void TestSearchProfile()
      {
         ConnectionsApiService connectionsApiService = getService();

         Profiles response = connectionsApiService.SearchProfiles("stefano.pogliani@fr.ibm.com", 1, 500);
         Assert.AreEqual(true, response.IsSuccesful);
         int totalEntries = (response.profiles == null ? 0 : response.profiles.Count);
         Assert.IsTrue(response.profiles.Count>0); 
         Assert.IsNotNull(response.profiles[0].Title);
      }
      [TestMethod]
      public void TestGetMyFiles()
      {
         ConnectionsApiService connectionsApiService = getService();

         Files response = connectionsApiService.GetMyFiles(1, 500, null);
         Assert.AreEqual(true, response.IsSuccesful);
         Assert.IsNotNull(response.TotalResults);
         Assert.IsTrue(response.TotalResults >= response.fileEntry.Count);
      }
      [TestMethod]
      public void TestGetMyFilesCloud()
      {
         ConnectionsApiService connectionsApiService = getService(true);

         Files response = connectionsApiService.GetMyFiles(1, 500, null);
         Assert.AreEqual(true, response.IsSuccesful);
         Assert.IsNotNull(response.TotalResults);
         Assert.IsTrue(response.TotalResults >= response.fileEntry.Count);
      }

      //[TestMethod]
      //public void TestDownloadFile()
      //{
      //   ConnectionsApiService connectionsApiService = getService();

      //   Files response = connectionsApiService.GetMyFiles(1, 500, new string[] { "docx" });
      //   Assert.AreEqual(true, response.IsSuccesful);
      //   Assert.IsNotNull(response.TotalResults);
      //   Assert.IsTrue(response.TotalResults >= response.fileEntry.Count);
      //   string fileId = response.fileEntry[0].uuid;
      //   byte[] fileDownloaded = connectionsApiService.FilesService.DownloadFile(fileId, response.fileEntry[0].label);
      //   Assert.IsNotNull(fileDownloaded);

      //}

    
      

      [TestMethod]
      public void TestGetPeopleFollowing()
      {
         ConnectionsApiService connectionsApiService = getService();

         Profiles response = connectionsApiService.GetPeopleFollowing();
         Assert.AreEqual(true, response.IsSuccesful);
         int totalEntries = (response.profiles == null ? 0 : response.profiles.Count);

         Assert.IsNotNull(response.profiles);
         Assert.IsTrue(totalEntries > -response.profiles.Count);
         Assert.IsNotNull(response.profiles[0].Title);
      }

   }

   //[TestFixture]
   //public class SectionTests
   //{
   //   [Test]
   //   public void TestPing()
   //   {
   //      IMailChimpApiService mailChimpApiService = new MailChimpApiService(MailChimpServiceConfiguration.Settings.ApiKey);

   //      var response = mailChimpApiService.PingMailChimpServer();
   //      Console.WriteLine(response.ResponseJson);
   //      Assert.AreEqual(true, response.IsSuccesful);
   //   }

   //   [TestCase("spyros{0}@gmail.com", 5)]
   //   public void TestSubscribe(string emailPattern, int numberOfEmails)
   //   {
   //      IMailChimpApiService mailChimpApiService = new MailChimpApiService(MailChimpServiceConfiguration.Settings.ApiKey);
   //      for (int i = 0; i < numberOfEmails; i++)
   //      {
   //         var response = mailChimpApiService.Subscribe(String.Format(emailPattern, i), false);
   //         Console.WriteLine(response.ResponseJson);
   //         Assert.AreEqual(true, response.IsSuccesful);
   //      }
   //   }

   //   [TestCase("spyros_bluecoupon{0}@gmail.com", 5)]
   //   public void TestSubscribeWithGroupingsAndMergeVars(string emailPattern, int numberOfEmails)
   //   {
   //      IMailChimpApiService mailChimpApiService = new MailChimpApiService(MailChimpServiceConfiguration.Settings.ApiKey);
   //      for (int i = 0; i < numberOfEmails; i++)
   //      {
   //         var subscribeSources = new Grouping { Name = "Subscribe Source" };
   //         subscribeSources.Groups.Add("Site");

   //         var couponsGained = new Grouping { Name = "Coupons Gained" };
   //         couponsGained.Groups.Add("Coupon1");

   //         var interests = new Grouping { Name = "Interests" };
   //         interests.Groups.Add("Extreme Games");


   //         var fields = new Dictionary<string, string>
   //                 {
   //                     {"GENDER", "Male"},
   //                     {"DATEBORN", DateTime.Now.ToString(CultureInfo.InvariantCulture)},
   //                     {"CITY", "Athens"},
   //                     {"COUNTRY", "Greece"}
   //                 };

   //         var response = mailChimpApiService.Subscribe(String.Format(emailPattern, i), new List<Grouping>() { subscribeSources, couponsGained, interests }, fields, false);
   //         Console.WriteLine(response.ResponseJson);
   //         Assert.AreEqual(true, response.IsSuccesful);
   //      }
   //   }

   //   [TestCase("spyros_bluecoupon{0}@gmail.com", 5)]
   //   public void TestSubscribeWithGroupingsAndMergeVarsAndCustomListId(string emailPattern, int numberOfEmails)
   //   {
   //      IMailChimpApiService mailChimpApiService = new MailChimpApiService(MailChimpServiceConfiguration.Settings.ApiKey);
   //      const string customListId = "71d6c2a0f0";
   //      for (int i = 0; i < numberOfEmails; i++)
   //      {
   //         var subscribeSources = new Grouping { Name = "Subscribe Source" };
   //         subscribeSources.Groups.Add("Site");

   //         var couponsGained = new Grouping { Name = "Coupons Gained" };
   //         couponsGained.Groups.Add("Coupon1");

   //         var interests = new Grouping { Name = "Interests" };
   //         interests.Groups.Add("Extreme Games");


   //         var fields = new Dictionary<string, string>
   //                 {
   //                     {"GENDER", "Male"},
   //                     {"DATEBORN", DateTime.Now.ToString(CultureInfo.InvariantCulture)},
   //                     {"CITY", "Athens"},
   //                     {"COUNTRY", "Greece"}
   //                 };

   //         var response = mailChimpApiService.Subscribe(String.Format(emailPattern, i),
   //             customListId,
   //             new List<Grouping>() { subscribeSources, couponsGained, interests },
   //             fields,
   //             false);

   //         Console.WriteLine(response.ResponseJson);
   //         Assert.AreEqual(true, response.IsSuccesful);
   //      }
   //   }


   //   [TestCase("spyros{0}@gmail.com", 5)]
   //   public void TestUnSubscribe(string emailPattern, int numberOfEmails)
   //   {
   //      IMailChimpApiService mailChimpApiService = new MailChimpApiService(MailChimpServiceConfiguration.Settings.ApiKey);
   //      for (int i = 0; i < numberOfEmails; i++)
   //      {
   //         var response = mailChimpApiService.Unsubscribe(String.Format(emailPattern, i));
   //         Console.WriteLine(response.ResponseJson);
   //         //Assert.AreEqual(true, response.IsSuccesful);
   //      }
   //   }
   //}
}
