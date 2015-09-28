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

namespace Samples.UI
{
   public partial class OfficeSideBar : UserControl
   {
      IBM.Connections.Net.Api.ConnectionsApiService connectionsAPIService;
      public event EventHandler FileSelected;
      public OfficeSideBar()
      {
         InitializeComponent();
         connectionsAPIService = new IBM.Connections.Net.Api.ConnectionsApiService("https://dubxpcvm1192.mul.ie.ibm.com:9444", "ajones1", "jones1");
         this.listViewCommunities.SelectedIndexChanged += new System.EventHandler(this.ReturnDocumentLink);
         this.listViewMyFiles.SelectedIndexChanged += new System.EventHandler(this.ReturnDocumentLink);
         this.listViewSharedWithMe.SelectedIndexChanged += new System.EventHandler(this.ReturnDocumentLink);
         StartAsyncMyFiles();
      }

      private void ReturnDocumentLink(object sender, EventArgs e)
      {
         FileSelected(sender,e);    
    
      }
      private async void StartAsyncMyFiles()
      {
         StartProgress();
         ControlTabs.SelectTab(0);
         Task<FilesResult> task3 = Task<FilesResult>.Factory.StartNew(() =>
         {
            //load files
            IBM.Connections.Net.Api.Models.Request.Files request = new IBM.Connections.Net.Api.Models.Request.Files();
            request.page = 1;
            request.pageSize = 500;
            FilesResult response = connectionsAPIService.FilesService.GetMyFiles(request);
            return response;
         });

         // start more work
         var moreWork = Task.Run(() => { showFiles(task3.Result, listViewMyFiles); });

         // wait until “more work” finishes
         await moreWork;
      }
      private async void StartAsyncSharedWithMe()
      {
         StartProgress();

         ControlTabs.SelectTab(1);
         Task<FilesResult> task3 = Task<FilesResult>.Factory.StartNew(() =>
         {
            //load files
            IBM.Connections.Net.Api.Models.Request.FilesShared request = new IBM.Connections.Net.Api.Models.Request.FilesShared();
            request.page = 1;
            request.pageSize = 500;
            request.direction = IBM.Connections.Net.Api.Models.Request.FilesShared.Direction.inbound;
            FilesResult response = connectionsAPIService.FilesService.GetFileShared(request);
            return response;
         });

         // start more work
         var moreWork = Task.Run(() => { showFiles(task3.Result, listViewSharedWithMe); });

         // wait until “more work” finishes
         await moreWork;
      }
      private async void StartAsyncCommunityFiles(string communityID)
      {
         StartProgress();

         ControlTabs.SelectTab(2);
         Task<FilesResult> task3 = Task<FilesResult>.Factory.StartNew(() =>
         {
            //load files
            IBM.Connections.Net.Api.Models.Request.CommunityFiles request = new IBM.Connections.Net.Api.Models.Request.CommunityFiles();
            request.page = 1;
            request.pageSize = 500;
            request.CommunityId = communityID;
            FilesResult response = connectionsAPIService.CommunitiesService.GetCommunityFiles(request);
            return response;
         });

         // start more work
         var moreWork = Task.Run(() => { showFiles(task3.Result, listViewCommunities); });

         // wait until “more work” finishes
         await moreWork;
      }
      private void LoadCommunities()
      {
         StartProgress();
         ControlTabs.SelectTab(2);
         //load communities
         IBM.Connections.Net.Api.Models.Request.Communities request = new IBM.Connections.Net.Api.Models.Request.Communities();
         request.page = 1;
         request.pageSize = 500;
         CommunitiesResult response = connectionsAPIService.CommunitiesService.GetMyCommunities(request);
         cmbCommunities.Items.Clear();
         foreach (var item in response.CommunityEntry)
         {
            cmbCommunities.Items.Add(new Item(item.Title, item.CommunityUuid));
         }
         StopProgress();

      }


      void showFiles(FilesResult files, ListView listToShow)
      {
        
         listToShow.BeginInvoke(new Action(() =>
         {

            //clear contents
            listToShow.Clear();
            // Create columns for the items and subitems.
            listToShow.Columns.Add("Filename", 400, HorizontalAlignment.Left);
            foreach (var file in files.FilesEntry)
            {
               ListViewItem item = new ListViewItem(file.Label, 0);
               item.Tag = file;
               listToShow.Items.Add(item);
            }

            listToShow.Show();

         }));
         StopProgress();
      }

      void StartProgress()
      {
         progressBar1.MarqueeAnimationSpeed = 30;
      }
      
      void StopProgress()
      {
         this.progressBar1.BeginInvoke(new Action(() =>
         {
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Hide();
         }));
      }

      private void ControlTabs_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch (ControlTabs.SelectedIndex)
         {
            case 0:
               StartAsyncMyFiles();
               break;
            case 1:
               StartAsyncSharedWithMe();
               break;

            case 2:
               LoadCommunities();
               break;

            default:
               break;
         }
      }
                
      private void cmbCommunities_SelectedIndexChanged(object sender, EventArgs e)
      {
         Item itm = (Item)cmbCommunities.SelectedItem;

         StartAsyncCommunityFiles(itm.Value);
      }



      private class Item
      {
         public string Name;
         public string Value;
         public Item(string name, string value)
         {
            Name = name; Value = value;
         }
         public override string ToString()
         {
            // Generates the text shown in the combo box
            return Name;
         }
      }

    
   }
}
