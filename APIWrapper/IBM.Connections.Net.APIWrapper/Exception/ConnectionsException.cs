
using System.Collections.Generic;
namespace IBM.Connections.Net.Api.Exception
{
   public class ConnectionsException : System.Exception
   {
      /// <summary>
      ///     Response from the API
      /// </summary>
      public ConnectionsError Error { get; internal set; }

      /// <summary>
      ///     Status code of the response
      /// </summary>
      public int Status { get; internal set; }

      public ConnectionsException(int status, ConnectionsError error)
      {
         this.Error = error;
         this.Status = status;
      }
   }



   /// <summary>
   ///     Represent the error response from API
   /// </summary>
   public class ConnectionsError
   {
      public ConnectionsError(string status, string description, string details, Request request)
      {
         Status = status;
         Description = description;
         Details = details;
         FailedRequest = request;
      }
      public string Status { get; set; }

      public string Description { get; set; }

      public string Details { get; set; }

      public Request FailedRequest { get; set; }
   }

   public class Request
   {
      public Request(string url, IDictionary<string, string> parameters, string method)
      {
         Url = url;
         Parameters = parameters;
         Method = method;
      }
      public string Url { get; set; }

      public IDictionary<string, string> Parameters { get; set; }
   

      public string Method { get; set; }
   }
}

