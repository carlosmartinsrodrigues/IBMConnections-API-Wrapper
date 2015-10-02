using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Samples.WebApp.Helpers
{
   public static class ProfileHelper
   {
      public static string GetBusinessCardJS(this HtmlHelper helper)
      {
         return System.Configuration.ConfigurationManager.AppSettings["ConnectionsURL"] + "/profiles/ibm_semanticTagServlet/javascript/semanticTagService.js";
      }
      public static MvcHtmlString ProfileLinkFromActivity(this HtmlHelper helper, IBM.Connections.Net.Api.Models.ActivityStream.LinkInformation link, string username)
      {
         if (link == null)
            return MvcHtmlString.Create("");


         if (link != null && link.Href.IndexOf("/profiles/html/profileView.do?userid")>0)
         {
            return MvcHtmlString.Create(string.Format("<a href='{0}' target='_blank'>{1}</a>", link.Href,username));
         }else
            return MvcHtmlString.Create(string.Format("<a href='{0}' target='_blank'><img height='20px' src='/images/connectionscontent.png'></a>",link.Href));
      }
   }
}