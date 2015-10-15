using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Samples.UI;
using System.Windows.Forms;
using IBM.Connections.Net.Api;
using IBM.Connections.Net.Api.Models.Result;
using Microsoft.Office.Interop.Word;
using IBM.Connections.Net.Api.Models;
using System.IO;
using IBM.Connections.Net.Api.Exception;
namespace Samples.OfficeAddIn
{
   public partial class OfficeRibbon
   {
      public ConnectionsApiService connectionsAPIService { get; set; }
      private void OfficeRibbon_Load(object sender, RibbonUIEventArgs e)
      {

      }
      void showAuthentication()
      {
         DialogResult dr = new DialogResult();
         Login login = new Login(connectionsAPIService);

         dr = login.ShowDialog();
         if (dr == DialogResult.OK)
         {
            connectionsAPIService = login.connectionsApiService;
            connectionsAPIService.config = login.connectionsApiService.config;//todo: perform deep copy
         }
      }
      void handleAuthentication()
      {

         if (connectionsAPIService == null)
         {
            showAuthentication();
         }
      }

      private void btnMyFiles_Click(object sender, RibbonControlEventArgs e)
      {
         DialogResult dr = new DialogResult();
         handleAuthentication();

         if (connectionsAPIService != null)
         {
            MyFiles form = new MyFiles(connectionsAPIService, new string[] { "doc", "docx" });
            dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
               // set the file name from the open file dialog
               Entry selectedFile = form.selectedFile;
               String UserId = form.UserUUId;
               //string docId= listViewFiles.SelectedItems[0].pr
               //todo: download file


               try
               {
                  byte[] fileData = connectionsAPIService.FilesService.DownloadFile(UserId, selectedFile.Uuid, selectedFile.Label);
                  string fileNameFullPath;
                  fileNameFullPath = string.Format(@"c:\temp\{0}", selectedFile.Uuid);
                  System.IO.Directory.CreateDirectory(fileNameFullPath);
                  fileNameFullPath += "\\" + selectedFile.Label;
                  File.WriteAllBytes(fileNameFullPath, fileData);
                  Globals.ThisAddIn.Application.Documents.Open(@fileNameFullPath);
               }
               catch (Exception ex)
               {
                  MessageBox.Show("Error as occoured" + ex.InnerException);
               }

            }
         }
         else
         {
            MessageBox.Show("Error as occoured");
         }
      }

      private void btnSave_Click(object sender, RibbonControlEventArgs e)
      {

      }

      private void button1_Click(object sender, RibbonControlEventArgs e)
      {
         showAuthentication();
      }

      private void button2_Click(object sender, RibbonControlEventArgs e)
      {

         handleAuthentication();

         var result = connectionsAPIService.ProfilesService.GetMyProfile();
         Microsoft.Office.Interop.Word.Range rng = Globals.ThisAddIn.Application.Selection.Range;

         if (rng != null)
            rng.Text = result.items.Email;
      }





   }
}
