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
using IBM.Connections.Net.Api;
namespace Samples.UI
{
   public partial class Login : Form
   {
      public ConnectionsApiService connectionsApiService;
      public Login(ConnectionsApiService connectionsApiService)
      {
         InitializeComponent();
         

         if (connectionsApiService!=null)
         {
            //show already authenticated
            lblAuthenticated.Text = string.Format("You're already authenticated as {0}", connectionsApiService.config.User);
         }
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         connectionsApiService = new ConnectionsApiService(txtUrl.Text, txtUser.Text, txtPassword.Text);
         this.Close();
      }
   }
}
