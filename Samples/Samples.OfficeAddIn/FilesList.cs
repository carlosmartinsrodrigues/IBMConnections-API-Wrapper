using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Connections.Net.Api.Models;
using Samples.OfficeAddIn;

namespace OfficeAddIn
{
   public partial class FilesList : UserControl
   {
      string url;
      public FilesList()
      {
         InitializeComponent();
         //todo: add the load of my files
         listView1.Clear();

         IBM.Connections.Net.Api.ConnectionsApiService connectionsAPIService = new IBM.Connections.Net.Api.ConnectionsApiService("https://dubxpcvm1192.mul.ie.ibm.com:9444", "ajones1", "jones1");
         //load files
         IBM.Connections.Net.Api.Models.Request.Files request = new IBM.Connections.Net.Api.Models.Request.Files();
         request.page = 1;
         request.pageSize = 500;

         FilesResult response = connectionsAPIService.FilesService.GetMyFiles(request);
         url = response.collection.Href;
         if (response != null)
         {
            // Create columns for the items and subitems.
            listView1.Columns.Add("Filename", 400, HorizontalAlignment.Left);
            foreach (var file in response.FilesEntry)
            {
               ListViewItem item = new ListViewItem(file.Label, 0);
               item.Tag = file;
               listView1.Items.Add(item);
            }
         }

      }


      private void listView1_SelectedIndexChanged(object sender, EventArgs e)
      {
         //todo: add event to write to document
         if (this.listView1.SelectedItems.Count == 0)
            return;
         IBM.Connections.Net.Api.Models.Result.Entry file = (IBM.Connections.Net.Api.Models.Result.Entry)listView1.SelectedItems[0].Tag;

         // Insert a hyperlink to the Web page.
         string link = file.FileLinks.Where(t => t.Type == "text/html").Select(t => t.Href).FirstOrDefault();

         // get the range
         Microsoft.Office.Interop.Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;

         if (currentRange != null)
         {
            Microsoft.Office.Interop.Word.Hyperlink hp = (Microsoft.Office.Interop.Word.Hyperlink)
                currentRange.Hyperlinks.Add(currentRange, link);

            hp.TextToDisplay = file.Label;

         }
       
        
         
      }
   }
}
