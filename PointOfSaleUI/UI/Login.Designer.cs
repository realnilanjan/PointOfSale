namespace PointOfSaleUI.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.chkShowHidePassword = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(118, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to Point of Sale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(235, 143);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(300, 22);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "realnilanjan";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(235, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "admin";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(409, 211);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 47);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Location = new System.Drawing.Point(235, 223);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(105, 18);
            this.chkRememberMe.TabIndex = 6;
            this.chkRememberMe.Text = "Remember Me";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkForgotPassword.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lnkForgotPassword.Location = new System.Drawing.Point(233, 244);
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(126, 14);
            this.lnkForgotPassword.TabIndex = 7;
            this.lnkForgotPassword.TabStop = true;
            this.lnkForgotPassword.Text = "Forgot Password? Reset";
            this.lnkForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkShowHidePassword
            // 
            this.chkShowHidePassword.AutoSize = true;
            this.chkShowHidePassword.Location = new System.Drawing.Point(235, 202);
            this.chkShowHidePassword.Name = "chkShowHidePassword";
            this.chkShowHidePassword.Size = new System.Drawing.Size(110, 18);
            this.chkShowHidePassword.TabIndex = 5;
            this.chkShowHidePassword.Text = "Show Password";
            this.chkShowHidePassword.UseVisualStyleBackColor = true;
            this.chkShowHidePassword.CheckedChanged += new System.EventHandler(this.chkShowHidePassword_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PointOfSaleUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnkForgotPassword);
            this.Controls.Add(this.chkShowHidePassword);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.CheckBox chkShowHidePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}