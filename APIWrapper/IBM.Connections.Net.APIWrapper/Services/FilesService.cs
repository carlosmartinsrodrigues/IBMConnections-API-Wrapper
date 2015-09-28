using IBM.Connections.Net.Api.Models;
using IBM.Connections.Net.Api.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Connections.Net.Api.Helpers;
namespace IBM.Connections.Net.Api.Services
{
   public class FilesService
   {
      private readonly ConnectionsApiService _apiService;

      public FilesService(ConnectionsApiService currentInstance)
      {
         _apiService = currentInstance;
      }

      /// <summary>
      ///     Returns the list of following resources for the active user.
      ///     <para>API Reference: http://www-10.lotus.com/ldd/lcwiki.nsf/xpAPIViewer.xsp?lookupName=IBM+Connections+5.0+API+Documentation#action=openDocument&res_title=Getting_the_My_Activities_feed_ic50&content=apicontent</para>
      /// </summary>
      ///// <param name="requestParameters"></param>
      /// <returns></returns>
      public FilesResult GetMyFiles(IBM.Connections.Net.Api.Models.Request.Files requestParameters)
      {
         string url = string.Format("/files/basic/api/myuserlibrary/feed");

         return _apiService.Get<FilesResult>(url, requestParameters.ToDictionary());
      }

      /// <summary>
      ///     Returns the list of shared resources from or to the active user.
      ///     <para>API Reference:http://www-10.lotus.com/ldd/lcwiki.nsf/xpAPIViewer.xsp?lookupName=IBM+Connections+5.0+API+Documentation#action=openDocument&res_title=Getting_a_feed_of_file_shares_ic50&content=apicontent
      /// </summary>
      ///// <param name="requestParameters"></param>
      /// <returns></returns>
      public FilesResult GetFileShared(IBM.Connections.Net.Api.Models.Request.FilesShared requestParameters)
      {
         string url = string.Format("/files/basic/api/documents/shared/feed");


         return _apiService.Get<FilesResult>(url, requestParameters.ToDictionary());
      }

      /// <summary>
      ///     Returns the list of following resources for the active user.
      ///     <para>API Reference: http://www-10.lotus.com/ldd/lcwiki.nsf/xpAPIViewer.xsp?lookupName=IBM+Connections+5.0+API+Documentation#action=openDocument&res_title=Getting_the_My_Activities_feed_ic50&content=apicontent</para>
      /// </summary>
      ///// <param name="limit"></param>
      /// <returns></returns>
      public FilesResult GetPinnedFiles(IBM.Connections.Net.Api.Models.Request.Files requestParameters)
      {
         string url = string.Format("/files/basic/api/myfavorites/documents/feed");

         return _apiService.Get<FilesResult>(url, requestParameters.ToDictionary());
      }

      public byte[] DownloadFile(string documentId, string filename)
      {
         string url = string.Format("/files/basic/api/library/{0}/feed/document/{1}/media", _apiService.UserID, documentId);
         // string serviceUrl = config.serviceInformation.Where(t => t.Value.Title == MyFiles).SingleOrDefault().Value.URL;// "files/basic/api/library/e916c16d-749f-4faf-8e24-5205bfe2849f/feed";
         //string feed = "/feed";
         //if (serviceUrl.EndsWith(feed))
         //{
         //   serviceUrl = serviceUrl.Substring(0, serviceUrl.Length - feed.Length);
         //}
         ////"/files/basic/api/library/e916c16d-749f-4faf-8e24-5205bfe2849f/document/01ce031e-c029-476e-84c1-9613533cc95e/media"
         //serviceUrl += string.Format("/document/{0}/media", documentId);

         return _apiService.Download<FilesResult>(url);
      }

   }
}
