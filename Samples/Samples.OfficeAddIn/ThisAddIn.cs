using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using OfficeAddIn;
using Samples.UI;
using IBM.Connections.Net.Api.Models;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Samples.OfficeAddIn
{
   public partial class ThisAddIn
   {
      // private FilesList myUserControl1;
      private OfficeSideBar myUserControl1;
      private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;
      private void ThisAddIn_Startup(object sender, System.EventArgs e)
      {
         // myUserControl1 = new FilesList();
         myUserControl1 = new OfficeSideBar();
         myUserControl1.FileSelected += new EventHandler(this.AddLink_Handler);

         myCustomTaskPane = this.CustomTaskPanes.Add(myUserControl1, "My Task Pane");
         myCustomTaskPane.Visible = true;
         myCustomTaskPane.Width = 300;
      }

      private void AddLink_Handler(object sender, EventArgs e)
      {
         var itemCollection = ((ListView)sender).SelectedItems;
         if (itemCollection.Count == 0)
            return;

         IBM.Connections.Net.Api.Models.Result.Entry selectedFile = (IBM.Connections.Net.Api.Models.Result.Entry)itemCollection[0].Tag;

         // Insert a hyperlink to the Web page.
         string link = selectedFile.FileLinks.Where(t => t.Type == "text/html").Select(t=>t.Href).FirstOrDefault();
        
         // get the range
         Microsoft.Office.Interop.Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;

         if (currentRange != null)
         {
            Microsoft.Office.Interop.Word.Hyperlink hp = (Microsoft.Office.Interop.Word.Hyperlink)
                currentRange.Hyperlinks.Add(currentRange, link);

            hp.TextToDisplay = selectedFile.Label;

         }

      }

      private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
      {
      }

      #region VSTO generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InternalStartup()
      {
         this.Startup += new System.EventHandler(ThisAddIn_Startup);
         this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
      }

      #endregion
   }
}
