using IBM.Connections.Net.Api.Exception;
using IBM.Connections.Net.Api.Helpers;
using IBM.Connections.Net.Api.Models;
using IBM.Connections.Net.Api.Models.Internal;
using IBM.Connections.Net.Api.Models.Result;
using IBM.Connections.Net.Api.Services;
using IBM.Connections.Net.Settings;
using IBM.Connections.Net.Settings.Helpers;
using log4net;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBM.Connections.Net.Api
{
   public class ConnectionsApiService
   {

      //Services
      private readonly ILog _log = LogManager.GetLogger("ConnectionsApiService");
      private IBM.Connections.Net.Api.Models.Internal.UserCredentials user { get; set; }
      public ConnectionsServiceConfiguration config = new ConnectionsServiceConfiguration();

      public ConnectionsApiService(string url, string username, string password)
      {
         user = new IBM.Connections.Net.Api.Models.Internal.UserCredentials(username, password);
         fillConfiguration(url, username, password);
      }
      public ConnectionsServiceConfiguration GetConfig()
      {
         return config;
      }
      #region privateFunctions
      private void fillConfiguration(string url, string username, string password)
      {
         config.ServiceUrl = url;
         config.User = username;


         //if (config.serviceInformation == null)
         //   ServiceIntrospection();


         //if (config.serviceConfig == null)
         //   ServiceConfig();

      }



      private RestClient getClient()
      {
         var client = new RestClient(config.ServiceUrl);
         client.Authenticator = new HttpBasicAuthenticator(user.Username, user.Password);

         return client;
      }

      public string UserID
      {
         get
         {
            string userID = config.GetUserID();
            if (string.IsNullOrEmpty(userID))
            {
               var result = AuthenticationService.Authenticate(user.Username, user.Password);
               if (result.Authenticated)
               {
                  config.SetUserID(result.UserID);
                  userID = result.UserID;
               }
            }
            return userID;
         }
      }
      #endregion

      #region inspectServer


      /// <summary>
      /// Get the config of the server
      /// </summary>
      /// <returns></returns>
      public ServiceConfig ServiceConfig()
      {
         ServiceConfig serviceResponse = new ServiceConfig();

         try
         {

            var client = getClient();

            var request = new RestRequest(config.ConfigService, Method.GET);



            IRestResponse<ServiceConfig> response = client.Execute<ServiceConfig>(request);

            serviceResponse.IsSuccesful = (response.StatusCode == HttpStatusCode.OK);
            if (!serviceResponse.IsSuccesful)
               return null;

            serviceResponse = response.Data;

            Dictionary<Settings.Helpers.ServiceType, Uri> dictionary = new Dictionary<Settings.Helpers.ServiceType, Uri>();

            foreach (var item in serviceResponse.configEntry)
            {
               string serviceUrl = item.linkEntry[0].href;
               if (!string.IsNullOrEmpty(serviceUrl))
               {
                  Uri url = new Uri(serviceUrl);
                  dictionary.Add(ServiceInfo.GetServiceType(item.title), url);
               }
            }
            config.serviceConfig = dictionary;

         }
         catch (WebException exception)
         {
            using (Stream stream = exception.Response.GetResponseStream())
            {
               StreamReader reader = new StreamReader(stream, Encoding.UTF8);
               String responseString = reader.ReadToEnd();
               serviceResponse.RawResponse = responseString;
               _log.Error(responseString);
            }
            _log.Error(exception);

            serviceResponse.IsSuccesful = false;
         }
         return serviceResponse;
      }

      /// <summary>
      /// Get the introspection of the server
      /// </summary>
      /// <returns></returns>
      public ServiceIntrospection ServiceIntrospection()
      {
         ServiceIntrospection serviceResponse = new ServiceIntrospection();

         try
         {

            var client = getClient();

            var request = new RestRequest(config.IntrospectionService, Method.GET);

            IRestResponse<ServiceIntrospection> response = client.Execute<ServiceIntrospection>(request);

            serviceResponse.IsSuccesful = (response.StatusCode == HttpStatusCode.OK);
            if (!serviceResponse.IsSuccesful)
               return null;

            serviceResponse = response.Data;

            Dictionary<int, Settings.ServiceInfo> dictionary = new Dictionary<int, Settings.ServiceInfo>();

            int i = 0;
            foreach (var item in serviceResponse.app_workspace)
            {
               foreach (var collection in item.app_collection)
               {
                  dictionary.Add(i, new ServiceInfo(collection.title, collection.href.Replace(config.ServiceUrl, ""), item.title));
                  i++;
               }
            }
            config.serviceInformation = dictionary;

            Dictionary<string, string> dictionaryOperations = new Dictionary<string, string>();
            if (serviceResponse.operations != null)
            {
               foreach (var item in serviceResponse.operations.snx_operations)
               {
                  dictionaryOperations.Add(item.id, item.template);
               }
            }
            config.serviceOperations = dictionaryOperations;
         }
         catch (WebException exception)
         {
            using (Stream stream = exception.Response.GetResponseStream())
            {
               StreamReader reader = new StreamReader(stream, Encoding.UTF8);
               String responseString = reader.ReadToEnd();
               serviceResponse.RawResponse = responseString;
               _log.Error(responseString);
            }
            _log.Error(exception);

            serviceResponse.IsSuccesful = false;
         }
         return serviceResponse;
      }

      /// <summary>
      /// Get the introspection of the server
      /// </summary>
      /// <returns></returns>
      //private void UserIntrospection()
      //{
      //   UserServiceIntrospection serviceResponse = new UserServiceIntrospection();
      //   try
      //   {

      //      var client = getClient();

      //      var request = new RestRequest(config.UserIntrospectionService, Method.GET);

      //      IRestResponse<UserServiceIntrospection> response = client.Execute<UserServiceIntrospection>(request);

      //      bool IsSuccesful = (response.StatusCode == HttpStatusCode.OK);
      //      if (!IsSuccesful)
      //         return;

      //      serviceResponse = response.Data;

      //      config.SetUserID(serviceResponse.id);
      //      config.Name = serviceResponse.name;
      //      config.Email = serviceResponse.email;
      //   }
      //   catch (WebException exception)
      //   {
      //      using (Stream stream = exception.Response.GetResponseStream())
      //      {
      //         StreamReader reader = new StreamReader(stream, Encoding.UTF8);
      //         String responseString = reader.ReadToEnd();
      //         _log.Error(responseString);
      //      }
      //      _log.Error(exception);

      //   }
      //}
      #endregion


      #region Services
      /// <summary>
      ///     Provides all API methods in Tasks Area
      ///     <para>http://www-10.lotus.com/ldd/lcwiki.nsf/xpAPIViewer.xsp?lookupName=IBM+Connections+5.0+API+Documentation#action=openDocument&res_title=Activities_API_ic50&content=apicontent</para>
      /// </summary>
      public ActivitiesService ActivitiesService
      {
         get { return new ActivitiesService(this); }
      }

      public FilesService FilesService
      {
         get { return new FilesService(this); }
      }

      public CommunitiesService CommunitiesService
      {
         get { return new CommunitiesService(this); }
      }

      public ProfilesService ProfilesService
      {
         get { return new ProfilesService(this); }
      }


      public AuthenticationService AuthenticationService
      {
         get { return new AuthenticationService(this); }
      }
      #endregion


      #region Request Helpers

      internal T Get<T>(string url, IDictionary<string, string> requestData)
          where T : new()
      {
         return PerformAction<T>(url, requestData, Method.GET);
      }

      internal T Post<T>(string url, IDictionary<string, string> requestData)
        where T : new()
      {
         return PerformAction<T>(url, requestData, Method.POST);
      }
      internal T PerformAction<T>(string url, IDictionary<string, string> requestData, RestSharp.Method method)
            where T : new()
      {
         var client = getClient();

         var request = new RestRequest(url, method);
         if (requestData != null && requestData.Count > 0)
         {
            foreach (var item in requestData)
            {
               request.AddParameter(item.Key, item.Value);
            }
         }

         IRestResponse<T> response = client.Execute<T>(request);
         if (!(response.StatusCode == HttpStatusCode.OK))
         {

            var requestFailed = new Request(client.BaseUrl + url, requestData, method.ToString());
            string innerException = (response.ErrorException.InnerException != null) ? response.ErrorException.InnerException.ToString() : "";
            var connectionsError = new ConnectionsError(response.StatusCode.ToString(), response.StatusDescription, innerException, requestFailed);
            throw new ConnectionsException((int)response.StatusCode, connectionsError);
         }

         return response.Data;
      }
      internal byte[] Download<T>(string url)
         where T : new()
      {
         var client = getClient();

         var request = new RestRequest(url, Method.GET);

         return client.DownloadData(request);
      }
      #endregion

   }
}
