using IBM.Connections.Net.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Connections.Net.Api.Helpers;
namespace IBM.Connections.Net.Api.Services
{
     public class CommunitiesService
    {
        private readonly ConnectionsApiService _apiService;

        public CommunitiesService(ConnectionsApiService currentInstance)
        {
           _apiService = currentInstance;
        }

        /// <summary>
        ///     Returns the list of available communities for the active user.
        ///     <para>API Reference: http://www-10.lotus.com/ldd/lcwiki.nsf/xpAPIViewer.xsp?lookupName=IBM+Connections+5.0+API+Documentation#action=openDocument&res_title=Getting_the_My_Communities_feed_ic50&content=apicontent
        /// </summary>
        ///// <param name="limit"></param>
        /// <returns></returns>
        public CommunitiesResult GetMyCommunities(IBM.Connections.Net.Api.Models.Request.Communities request)
        {
           string url = string.Format("/communities/service/atom/communities/my");
            
           return _apiService.Get<CommunitiesResult>(url, request.ToDictionary());
        }

         /// <summary>
        ///     Returns the list of following resources for the active user.
        ///     <para>API Reference: http://www-10.lotus.com/ldd/lcwiki.nsf/xpAPIViewer.xsp?lookupName=IBM+Connections+5.0+API+Documentation#action=openDocument&res_title=Getting_the_My_Activities_feed_ic50&content=apicontent</para>
        /// </summary>
        ///// <param name="requestParameters"></param>
        /// <returns></returns>
        public FilesResult GetCommunityFiles(IBM.Connections.Net.Api.Models.Request.CommunityFiles requestParameters)
        {
           if(string.IsNullOrEmpty(requestParameters.CommunityId))
              return null;

           string url = string.Format("/files/basic/api/communitycollection/{0}/feed",requestParameters.CommunityId);

           return _apiService.Get<FilesResult>(url, requestParameters.ToDictionary());
        }
         

       
     }
}
