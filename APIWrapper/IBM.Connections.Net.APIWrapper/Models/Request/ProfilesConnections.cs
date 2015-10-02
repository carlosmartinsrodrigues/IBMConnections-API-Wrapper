using IBM.Connections.Net.Api.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBM.Connections.Net.Api.Models.Request
{
   public class ProfilesConnections : BaseRequest
   {
      public Type connectionType { get { return Type.colleague; } }


      public Status status { get; set; }
      public bool? inclMessage { get; set; }
      public string key { get; set; }
      public string Email { get; set; }
      public enum Status
      {
         accepted,
         pending,
         unconfirmed

      }
      public enum Type
      {

         colleague
      }

   }
}
