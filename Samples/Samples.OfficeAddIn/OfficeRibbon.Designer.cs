namespace Samples.OfficeAddIn
{
   partial class OfficeRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      public OfficeRibbon()
         : base(Globals.Factory.GetRibbonFactory())
      {
         InitializeComponent();
      }

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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeRibbon));
         this.tab1 = this.Factory.CreateRibbonTab();
         this.Open = this.Factory.CreateRibbonGroup();
         this.btnMyFiles = this.Factory.CreateRibbonButton();
         this.grpSave = this.Factory.CreateRibbonGroup();
         this.btnSave = this.Factory.CreateRibbonButton();
         this.grpAuthentication = this.Factory.CreateRibbonGroup();
         this.button1 = this.Factory.CreateRibbonButton();
         this.tab1.SuspendLayout();
         this.Open.SuspendLayout();
         this.grpSave.SuspendLayout();
         this.grpAuthentication.SuspendLayout();
         // 
         // tab1
         // 
         this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
         this.tab1.Groups.Add(this.grpAuthentication);
         this.tab1.Groups.Add(this.Open);
         this.tab1.Groups.Add(this.grpSave);
         this.tab1.Label = "Testing Connections";
         this.tab1.Name = "tab1";
         // 
         // Open
         // 
         this.Open.Items.Add(this.btnMyFiles);
         this.Open.Label = "Open";
         this.Open.Name = "Open";
         // 
         // btnMyFiles
         // 
         this.btnMyFiles.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
         this.btnMyFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnMyFiles.Image")));
         this.btnMyFiles.Label = "My Files";
         this.btnMyFiles.Name = "btnMyFiles";
         this.btnMyFiles.ShowImage = true;
         this.btnMyFiles.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnMyFiles_Click);
         // 
         // grpSave
         // 
         this.grpSave.Items.Add(this.btnSave);
         this.grpSave.Label = "Save";
         this.grpSave.Name = "grpSave";
         // 
         // btnSave
         // 
         this.btnSave.Label = "Save";
         this.btnSave.Name = "btnSave";
         this.btnSave.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSave_Click);
         // 
         // grpAuthentication
         // 
         this.grpAuthentication.Items.Add(this.button1);
         this.grpAuthentication.Label = "Authentication";
         this.grpAuthentication.Name = "grpAuthentication";
         // 
         // button1
         // 
         this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
         this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
         this.button1.Label = "Login";
         this.button1.Name = "button1";
         this.button1.ShowImage = true;
         this.button1.SuperTip = "Login";
         this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
         // 
         // OfficeRibbon
         // 
         this.Name = "OfficeRibbon";
         this.RibbonType = "Microsoft.Word.Document";
         this.Tabs.Add(this.tab1);
         this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.OfficeRibbon_Load);
         this.tab1.ResumeLayout(false);
         this.tab1.PerformLayout();
         this.Open.ResumeLayout(false);
         this.Open.PerformLayout();
         this.grpSave.ResumeLayout(false);
         this.grpSave.PerformLayout();
         this.grpAuthentication.ResumeLayout(false);
         this.grpAuthentication.PerformLayout();

      }

      #endregion

      internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
      internal Microsoft.Office.Tools.Ribbon.RibbonGroup Open;
      internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMyFiles;
      internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpSave;
      internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSave;
      internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpAuthentication;
      internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
   }

   partial class ThisRibbonCollection
   {
      internal OfficeRibbon OfficeRibbon
      {
         get { return this.GetRibbon<OfficeRibbon>(); }
      }
   }
}
