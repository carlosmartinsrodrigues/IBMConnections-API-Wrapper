namespace Samples.UI
{
   partial class OfficeSideBar
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.panel1 = new System.Windows.Forms.Panel();
         this.ControlTabs = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.listViewMyFiles = new System.Windows.Forms.ListView();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.listViewSharedWithMe = new System.Windows.Forms.ListView();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         this.cmbCommunities = new System.Windows.Forms.ComboBox();
         this.listViewCommunities = new System.Windows.Forms.ListView();
         this.panel1.SuspendLayout();
         this.ControlTabs.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.tabPage3.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.ControlTabs);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(260, 500);
         this.panel1.TabIndex = 0;
         // 
         // ControlTabs
         // 
         this.ControlTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.ControlTabs.Controls.Add(this.tabPage1);
         this.ControlTabs.Controls.Add(this.tabPage2);
         this.ControlTabs.Controls.Add(this.tabPage3);
         this.ControlTabs.Location = new System.Drawing.Point(4, 3);
         this.ControlTabs.Name = "ControlTabs";
         this.ControlTabs.SelectedIndex = 0;
         this.ControlTabs.Size = new System.Drawing.Size(253, 494);
         this.ControlTabs.TabIndex = 0;
         this.ControlTabs.Tag = "";
         this.ControlTabs.SelectedIndexChanged += new System.EventHandler(this.ControlTabs_SelectedIndexChanged);
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.listViewMyFiles);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(245, 468);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "My Files";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // listViewMyFiles
         // 
         this.listViewMyFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.listViewMyFiles.Location = new System.Drawing.Point(-8, -2);
         this.listViewMyFiles.Name = "listViewMyFiles";
         this.listViewMyFiles.Size = new System.Drawing.Size(257, 471);
         this.listViewMyFiles.TabIndex = 1;
         this.listViewMyFiles.UseCompatibleStateImageBehavior = false;
         this.listViewMyFiles.View = System.Windows.Forms.View.Details;
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.listViewSharedWithMe);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(245, 468);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Files Shared with Me";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // listViewSharedWithMe
         // 
         this.listViewSharedWithMe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.listViewSharedWithMe.Location = new System.Drawing.Point(-6, -1);
         this.listViewSharedWithMe.Name = "listViewSharedWithMe";
         this.listViewSharedWithMe.Size = new System.Drawing.Size(257, 471);
         this.listViewSharedWithMe.TabIndex = 2;
         this.listViewSharedWithMe.UseCompatibleStateImageBehavior = false;
         this.listViewSharedWithMe.View = System.Windows.Forms.View.Details;
         // 
         // tabPage3
         // 
         this.tabPage3.Controls.Add(this.progressBar1);
         this.tabPage3.Controls.Add(this.cmbCommunities);
         this.tabPage3.Controls.Add(this.listViewCommunities);
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Size = new System.Drawing.Size(245, 468);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "Community Files";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // progressBar1
         // 
         this.progressBar1.Location = new System.Drawing.Point(-6, 153);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(257, 23);
         this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
         this.progressBar1.TabIndex = 3;
         this.progressBar1.UseWaitCursor = true;
         // 
         // cmbCommunities
         // 
         this.cmbCommunities.FormattingEnabled = true;
         this.cmbCommunities.Location = new System.Drawing.Point(4, 4);
         this.cmbCommunities.Name = "cmbCommunities";
         this.cmbCommunities.Size = new System.Drawing.Size(238, 21);
         this.cmbCommunities.TabIndex = 3;
         this.cmbCommunities.SelectedIndexChanged += new System.EventHandler(this.cmbCommunities_SelectedIndexChanged);
         // 
         // listViewCommunities
         // 
         this.listViewCommunities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.listViewCommunities.Location = new System.Drawing.Point(-6, 31);
         this.listViewCommunities.Name = "listViewCommunities";
         this.listViewCommunities.Size = new System.Drawing.Size(257, 439);
         this.listViewCommunities.TabIndex = 2;
         this.listViewCommunities.UseCompatibleStateImageBehavior = false;
         this.listViewCommunities.View = System.Windows.Forms.View.Details;
         // 
         // OfficeSideBar
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.panel1);
         this.Name = "OfficeSideBar";
         this.Size = new System.Drawing.Size(260, 500);
         this.panel1.ResumeLayout(false);
         this.ControlTabs.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage2.ResumeLayout(false);
         this.tabPage3.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.TabControl ControlTabs;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.ListView listViewMyFiles;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.ListView listViewSharedWithMe;
      private System.Windows.Forms.ComboBox cmbCommunities;
      private System.Windows.Forms.ListView listViewCommunities;
      private System.Windows.Forms.ProgressBar progressBar1;

   }
}
