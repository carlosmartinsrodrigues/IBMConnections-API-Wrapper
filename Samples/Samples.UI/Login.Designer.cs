namespace Samples.UI
{
   partial class Login
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
         this.txtUrl = new System.Windows.Forms.TextBox();
         this.txtUser = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.btnLogin = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.lblAuthenticated = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // txtUrl
         // 
         this.txtUrl.Location = new System.Drawing.Point(72, 38);
         this.txtUrl.Name = "txtUrl";
         this.txtUrl.Size = new System.Drawing.Size(191, 20);
         this.txtUrl.TabIndex = 0;
         // 
         // txtUser
         // 
         this.txtUser.Location = new System.Drawing.Point(72, 85);
         this.txtUser.Name = "txtUser";
         this.txtUser.Size = new System.Drawing.Size(191, 20);
         this.txtUser.TabIndex = 0;
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(72, 138);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(191, 20);
         this.txtPassword.TabIndex = 0;
         this.txtPassword.UseSystemPasswordChar = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 38);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(29, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "URL";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(13, 88);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(29, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "User";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(13, 138);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(53, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Password";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(13, 85);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(29, 13);
         this.label4.TabIndex = 2;
         this.label4.Text = "User";
         // 
         // btnLogin
         // 
         this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnLogin.Location = new System.Drawing.Point(188, 213);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(75, 23);
         this.btnLogin.TabIndex = 3;
         this.btnLogin.Text = "Login";
         this.btnLogin.UseVisualStyleBackColor = true;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(92, 213);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 3;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // lblAuthenticated
         // 
         this.lblAuthenticated.AutoSize = true;
         this.lblAuthenticated.Location = new System.Drawing.Point(16, 182);
         this.lblAuthenticated.Name = "lblAuthenticated";
         this.lblAuthenticated.Size = new System.Drawing.Size(0, 13);
         this.lblAuthenticated.TabIndex = 4;
         // 
         // Login
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 261);
         this.Controls.Add(this.lblAuthenticated);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnLogin);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtUser);
         this.Controls.Add(this.txtUrl);
         this.Name = "Login";
         this.Text = "Login";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtUrl;
      private System.Windows.Forms.TextBox txtUser;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Label lblAuthenticated;
   }
}