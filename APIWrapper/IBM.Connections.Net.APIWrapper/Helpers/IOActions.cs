using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Connections.Net.Api.Helpers
{
    public class IOActions
    {
       public static bool ByteArrayToFile(string fileName, byte[] data)
       {
          try
          {
             // Open file for reading
             System.IO.FileStream _FileStream =
                new System.IO.FileStream(fileName, System.IO.FileMode.Create,
                                         System.IO.FileAccess.Write);
             // Writes a block of bytes to this stream using data from
             // a byte array.
             _FileStream.Write(data, 0, data.Length);

             // close file stream
             _FileStream.Close();

             return true;
          }
          catch (Exception _Exception)
          {
             // Error
             Console.WriteLine("Exception caught in process: {0}",
                               _Exception.ToString());
          }

          // error occured, return false
          return false;
       }
    }
   
}
