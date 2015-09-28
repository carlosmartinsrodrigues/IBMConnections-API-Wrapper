using IBM.Connections.Net.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Connections.Net.Api.Helpers;
namespace IBM.Connections.Net.Api.Services
{
     public class ActivitiesService
    {
        private readonly ConnectionsApiService _apiService;

        public ActivitiesService(ConnectionsApiService currentInstance)
        {
           _apiService = currentInstance;
        }

        /// <summary>
        ///     Returns the list of following resources for the active user.
        ///     <para>API Reference: http://www-10.lotus.com/ldd/lcwiki.nsf/xpAPIViewer.xsp?lookupName=IBM+Connections+5.0+API+Documentation#action=openDocument&res_title=Getting_the_My_Activities_feed_ic50&content=apicontent</para>
        /// </summary>
        ///// <param name="limit"></param>
        /// <returns></returns>
        public Activities GetMyActivities(IBM.Connections.Net.Api.Models.Request.Activities request)
        {
           string url = string.Format("/activities/service/atom2/activities");
            //var requestData = new Dictionary<string, string>()
            //{
            //    {"limit", limit.ToString()}
            //};
           return _apiService.Get<Activities>(url, request.ToDictionary());
        }

        /// <summary>
        ///     Returns the list of following resources for the active user.
        ///     <para>API Reference: http://www-10.lotus.com/ldd/lcwiki.nsf/xpAPIViewer.xsp?lookupName=IBM+Connections+5.0+API+Documentation#action=openDocument&res_title=Getting_the_My_Activities_feed_ic50&content=apicontent</para>
        /// </summary>
        ///// <param name="limit"></param>
        /// <returns></returns>
        public Activities GetCompleted(IBM.Connections.Net.Api.Models.Request.Activities request)
        {
           string url = string.Format("/activities/service/atom2/completed");
           //var requestData = new Dictionary<string, string>()
           //{
           //    {"limit", limit.ToString()}
           //};
           return _apiService.Get<Activities>(url, request.ToDictionary());
        }
     }
}
