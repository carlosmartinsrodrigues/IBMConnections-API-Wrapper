namespace OfficeAddIn
{
   partial class FilesList
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
         this.listView1 = new System.Windows.Forms.ListView();
         this.Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.SuspendLayout();
         // 
         // listView1
         // 
         this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Filename});
         this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listView1.Location = new System.Drawing.Point(0, 0);
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(174, 324);
         this.listView1.TabIndex = 0;
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.View = System.Windows.Forms.View.Details;
         this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
         // 
         // Filename
         // 
         this.Filename.Width = 164;
         // 
         // FilesList
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.listView1);
         this.Name = "FilesList";
         this.Size = new System.Drawing.Size(174, 324);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ListView listView1;
      private System.Windows.Forms.ColumnHeader Filename;
   }
}
