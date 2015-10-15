using IBM.Connections.Net.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace Samples.WebApp.Controllers
{
   public class HomeController : BaseController
   {
      public ActionResult Index()
      {
         return View();
      }

      [Authorize]
      public ActionResult MyFiles()
      {
         IBM.Connections.Net.Api.Models.FilesResult model = new IBM.Connections.Net.Api.Models.FilesResult();
         try
         {
            var request = new IBM.Connections.Net.Api.Models.Request.Files();
            model = getClient().FilesService.GetMyFiles(request);
         }
         catch (Exception)
         {


         }

         return View(model);
      }
      [Authorize]
      [HttpPost]
      public RedirectToRouteResult SetStatus(string StatusUpdate)
      {
         var request = new IBM.Connections.Net.Api.Models.Request.UpdateStatus();
         request.content = StatusUpdate;
         try
         {
            getClient().ActivitiesService.SetMyStatus(request);
         }
         catch (Exception)
         {

         }
         
         return RedirectToAction("Following");
      }
      [Authorize]
      public ActionResult Following()
      {
         IBM.Connections.Net.Api.Models.ActivityStream model = new IBM.Connections.Net.Api.Models.ActivityStream();
         try
         {
            model = getClient().ActivitiesService.GetMyActivityStream();
         }
         catch (Exception)
         {

         }
         return View(model);
      }

   }
}