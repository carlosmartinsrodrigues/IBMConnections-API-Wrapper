namespace Samples.UI
{
   partial class MyFiles
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btnOk = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.listViewFiles = new System.Windows.Forms.ListView();
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         this.SuspendLayout();
         // 
         // btnOk
         // 
         this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnOk.Location = new System.Drawing.Point(621, 524);
         this.btnOk.Name = "btnOk";
         this.btnOk.Size = new System.Drawing.Size(75, 23);
         this.btnOk.TabIndex = 1;
         this.btnOk.Text = "Open";
         this.btnOk.UseVisualStyleBackColor = true;
         this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(526, 524);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 1;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // listViewFiles
         // 
         this.listViewFiles.Location = new System.Drawing.Point(13, 34);
         this.listViewFiles.Name = "listViewFiles";
         this.listViewFiles.Size = new System.Drawing.Size(683, 470);
         this.listViewFiles.TabIndex = 0;
         this.listViewFiles.UseCompatibleStateImageBehavior = false;
         this.listViewFiles.View = System.Windows.Forms.View.Details;
         // 
         // progressBar1
         // 
         this.progressBar1.Location = new System.Drawing.Point(220, 170);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(257, 23);
         this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
         this.progressBar1.TabIndex = 2;
         this.progressBar1.UseWaitCursor = true;
         // 
         // MyFiles
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(708, 559);
         this.Controls.Add(this.progressBar1);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOk);
         this.Controls.Add(this.listViewFiles);
         this.Name = "MyFiles";
         this.Text = "MyFiles";
         this.Load += new System.EventHandler(this.MyFiles_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnOk;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.ListView listViewFiles;
      private System.Windows.Forms.ProgressBar progressBar1;
   }
}