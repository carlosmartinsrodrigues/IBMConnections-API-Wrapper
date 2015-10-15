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
using System.Web.Security;

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
      IAuthenticationManager Authentication
      {
         get { return HttpContext.GetOwinContext().Authentication; }
      }
      //
      // POST: /Account/Login
      [HttpPost]
      [AllowAnonymous]
      public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
      {
         if (!ModelState.IsValid)
         {
            return View(model);
         }

         var url = System.Configuration.ConfigurationManager.AppSettings["ConnectionsUrl"];
         var connectionsApiService = new ConnectionsApiService(url, model.Username, model.Password);
         var result = connectionsApiService.AuthenticationService.Authenticate(model.Username, model.Password);
         if (result.Authenticated)
         {
            var identity = new ClaimsIdentity(new[] {
                            new Claim(ClaimTypes.Name, result.Name),
                        },
                     DefaultAuthenticationTypes.ApplicationCookie,
                     ClaimTypes.Name, ClaimTypes.Role);

            identity.AddClaim(new Claim("Token", result.Token));
            identity.AddClaim(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", result.UserID));
            identity.AddClaim(new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", result.Name));

            // if you want roles, just add as many as you want here (for loop maybe?)
            identity.AddClaim(new Claim(ClaimTypes.Role, "guest"));
            // tell OWIN the identity provider, optional
             identity.AddClaim(new Claim("IdentityProvider", "ConnectionsAuth"));

            Authentication.SignIn(new AuthenticationProperties
            {
               IsPersistent = model.RememberMe
            }, identity);

            return RedirectToLocal(returnUrl);
         }
         else
         {
            ModelState.AddModelError("", "Invalid login attempt.");
            return View(model);
         }

      }


      //
      // POST: /Account/LogOff
      [HttpPost]
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