using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Api.Models
{
    public class BaseResponse
    {
        public bool IsSuccesful { get; set; }

        public string RawResponse { get; set; }
    }
}
