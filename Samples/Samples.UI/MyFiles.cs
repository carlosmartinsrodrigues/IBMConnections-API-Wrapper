using IBM.Connections.Net.Api;
using IBM.Connections.Net.Api.Models;
using IBM.Connections.Net.Api.Models.Result;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Connections.Net.Api.Models;
namespace Samples.UI
{
   public partial class MyFiles : Form
   {
      public MyFiles(ConnectionsApiService connectionsAPIService, string[] filter)
      {
         InitializeComponent();
         Filter = filter;
         ConnectionsAPIService = connectionsAPIService;
         StartAsync();
         // Set the view to show details.
         listViewFiles.View = View.Details;
         // Allow the user to edit item text.
         listViewFiles.LabelEdit = true;
         // Allow the user to rearrange columns.
         listViewFiles.AllowColumnReorder = true;
         // Display check boxes.
         listViewFiles.CheckBoxes = false;
         // Select the item and subitems when selection is made.
         listViewFiles.FullRowSelect = true;
         // Display grid lines.
         listViewFiles.GridLines = true;
         // Sort the items in the list in ascending order.
         listViewFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
      }
      string[] Filter { get; set; }
      public IBM.Connections.Net.Api.Models.Result.Entry selectedFile { get; set; }
      public string UserUUId { get; set; }
      ConnectionsApiService ConnectionsAPIService { get; set; }

      private void MyFiles_Load(object sender, EventArgs e)
      {
         listViewFiles.Hide();
         progressBar1.MarqueeAnimationSpeed = 30;
       
       
      }
      private async void StartAsync()
      {
         Task<FilesResult> task3 = Task<FilesResult>.Factory.StartNew(() =>
         {
            //load files
            IBM.Connections.Net.Api.Models.Request.Files request = new IBM.Connections.Net.Api.Models.Request.Files();
            request.page = 1;
            request.pageSize = 500;
            request.Filter = Filter;
            FilesResult response = ConnectionsAPIService.FilesService.GetMyFiles(request);
            UserUUId = response.Uuid;
            return response;
         });

         // start more work
         var moreWork = Task.Run(() => { showFiles(task3.Result); });

         // wait until “more work” finishes
         await moreWork;
      }
      void showFiles(FilesResult files)
      {
         this.listViewFiles.BeginInvoke(new Action(() =>
         {
         
         //clear contents
         listViewFiles.Clear();
         // Create columns for the items and subitems.
         listViewFiles.Columns.Add("Filename", 400, HorizontalAlignment.Left);
         listViewFiles.Columns.Add("Last Modified", 100, HorizontalAlignment.Left);
         foreach (var file in files.FilesEntry)
         {
            ListViewItem item = new ListViewItem(file.Label, 0);
            item.SubItems.Add(file.Modified.ToString("dd/MM/yyyy"));
            item.Tag = file;
            listViewFiles.Items.Add(item);
         }
       
         listViewFiles.Show();
       
         }));
         this.progressBar1.BeginInvoke(new Action(() =>
         {
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Hide();
         }));
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void btnOk_Click(object sender, EventArgs e)
      {
         if (listViewFiles.SelectedItems.Count > 0)
            selectedFile = (Entry)listViewFiles.SelectedItems[0].Tag;

         this.Close();
      }

   }
}
