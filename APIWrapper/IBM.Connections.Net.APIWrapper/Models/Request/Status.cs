using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Connections.Net.Api.Helpers;
namespace IBM.Connections.Net.Api.Models.Request
{
   public class Status : BaseRequest
   {
      public Comments comments { get; set; }
      public string email { get; set; }
      [ToMiliseconds]
      public DateTime since { get; set; }
      public string sinceEntryId { get; set; }
      public MessageType messageTypes { get; set; }
      public SortBy sortBy { get; set; }
      public enum MessageType
      {
         status,
         simpleEntry
      }
      public enum SortBy
      {
         moderated,
         published
      }
      public enum Comments
      {
         all,
         inline,
         none

      }
   }
}
