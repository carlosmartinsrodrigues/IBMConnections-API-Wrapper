using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Samples.WebApp.Models;
using IBM.Connections.Net.Api;

namespace Samples.WebApp.Controllers
{
   [Authorize]
   public class AccountController : Controller
   {
      private ApplicationSignInManager _signInManager;
      private ApplicationUserManager _userManager;

      public AccountController()
      {
      }

      public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
      {
         UserManager = userManager;
         SignInManager = signInManager;
      }

      public ApplicationSignInManager SignInManager
      {
         get
         {
            return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
         }
         private set
         {
            _signInManager = value;
         }
      }

      public ApplicationUserManager UserManager
      {
         get
         {
            return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
         }
         private set
         {
            _userManager = value;
         }
      }

      //
      // GET: /Account/Login
      [AllowAnonymous]
      public ActionResult Login(string returnUrl)
      {
         ViewBag.ReturnUrl = returnUrl;
         return View();
      }

      //
      // POST: /Account/Login
      [HttpPost]
      [AllowAnonymous]
      [ValidateAntiForgeryToken]
      public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
      {
         if (!ModelState.IsValid)
         {
            return View(model);
         }

         var url = System.Configuration.ConfigurationManager.AppSettings["ConnectionsUrl"];
         var connectionsApiService = new ConnectionsApiService(url, model.Username, model.Password);
         var result=connectionsApiService.AuthenticationService.Authenticate(model.Username, model.Password);
         if (result.Authenticated)
            return RedirectToLocal(returnUrl);
         else
         {
            ModelState.AddModelError("", "Invalid login attempt.");
            return View(model);
         }
        
      }

     
      //
      // POST: /Account/LogOff
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult LogOff()
      {
         AuthenticationManager.SignOut();
         return RedirectToAction("Index", "Home");
      }

      //
      // GET: /Account/ExternalLoginFailure
      [AllowAnonymous]
      public ActionResult ExternalLoginFailure()
      {
         return View();
      }

      protected override void Dispose(bool disposing)
      {
         if (disposing)
         {
            if (_userManager != null)
            {
               _userManager.Dispose();
               _userManager = null;
            }

            if (_signInManager != null)
            {
               _signInManager.Dispose();
               _signInManager = null;
            }
         }

         base.Dispose(disposing);
      }

      #region Helpers
      // Used for XSRF protection when adding external logins
      private const string XsrfKey = "XsrfId";

      private IAuthenticationManager AuthenticationManager
      {
         get
         {
            return HttpContext.GetOwinContext().Authentication;
         }
      }

      private void AddErrors(IdentityResult result)
      {
         foreach (var error in result.Errors)
         {
            ModelState.AddModelError("", error);
         }
      }

      private ActionResult RedirectToLocal(string returnUrl)
      {
         if (Url.IsLocalUrl(returnUrl))
         {
            return Redirect(returnUrl);
         }
         return RedirectToAction("Index", "Home");
      }

      internal class ChallengeResult : HttpUnauthorizedResult
      {
         public ChallengeResult(string provider, string redirectUri)
            : this(provider, redirectUri, null)
         {
         }

         public ChallengeResult(string provider, string redirectUri, string userId)
         {
            LoginProvider = provider;
            RedirectUri = redirectUri;
            UserId = userId;
         }

         public string LoginProvider { get; set; }
         public string RedirectUri { get; set; }
         public string UserId { get; set; }

         public override void ExecuteResult(ControllerContext context)
         {
            var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
            if (UserId != null)
            {
               properties.Dictionary[XsrfKey] = UserId;
            }
            context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
         }
      }
      #endregion
   }
}