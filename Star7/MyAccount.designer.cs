namespace Star7
{
    partial class MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNewPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.LblNewPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblOldPassword = new System.Windows.Forms.Label();
            this.TBOldPassword = new System.Windows.Forms.TextBox();
            this.LblConfNewPassword = new System.Windows.Forms.Label();
            this.TBConfNewPassword = new System.Windows.Forms.TextBox();
            this.HideTopology = new System.Windows.Forms.Label();
            this.HideDevice = new System.Windows.Forms.Label();
            this.HidePassword = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdate.Location = new System.Drawing.Point(215, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(231, 43);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update changes";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(324, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(204, 22);
            this.txtEmail.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(128, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email";
            // 
            // TBNewPassword
            // 
            this.TBNewPassword.Location = new System.Drawing.Point(324, 288);
            this.TBNewPassword.Name = "TBNewPassword";
            this.TBNewPassword.Size = new System.Drawing.Size(204, 22);
            this.TBNewPassword.TabIndex = 18;
            this.TBNewPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(324, 187);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(204, 22);
            this.txtUser.TabIndex = 17;
            // 
            // LblNewPassword
            // 
            this.LblNewPassword.AutoSize = true;
            this.LblNewPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.LblNewPassword.Location = new System.Drawing.Point(128, 291);
            this.LblNewPassword.Name = "LblNewPassword";
            this.LblNewPassword.Size = new System.Drawing.Size(107, 19);
            this.LblNewPassword.TabIndex = 16;
            this.LblNewPassword.Text = "New Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblUser.Location = new System.Drawing.Point(128, 187);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 19);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(222, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Account Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(173, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Change username or password";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 31);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // LblOldPassword
            // 
            this.LblOldPassword.AutoSize = true;
            this.LblOldPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.LblOldPassword.Location = new System.Drawing.Point(128, 253);
            this.LblOldPassword.Name = "LblOldPassword";
            this.LblOldPassword.Size = new System.Drawing.Size(101, 19);
            this.LblOldPassword.TabIndex = 25;
            this.LblOldPassword.Text = "Old Password";
            // 
            // TBOldPassword
            // 
            this.TBOldPassword.Location = new System.Drawing.Point(324, 250);
            this.TBOldPassword.Name = "TBOldPassword";
            this.TBOldPassword.Size = new System.Drawing.Size(204, 22);
            this.TBOldPassword.TabIndex = 26;
            this.TBOldPassword.UseSystemPasswordChar = true;
            // 
            // LblConfNewPassword
            // 
            this.LblConfNewPassword.AutoSize = true;
            this.LblConfNewPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.LblConfNewPassword.Location = new System.Drawing.Point(128, 324);
            this.LblConfNewPassword.Name = "LblConfNewPassword";
            this.LblConfNewPassword.Size = new System.Drawing.Size(164, 19);
            this.LblConfNewPassword.TabIndex = 27;
            this.LblConfNewPassword.Text = "Confirm New Password";
            // 
            // TBConfNewPassword
            // 
            this.TBConfNewPassword.Location = new System.Drawing.Point(324, 324);
            this.TBConfNewPassword.Name = "TBConfNewPassword";
            this.TBConfNewPassword.Size = new System.Drawing.Size(204, 22);
            this.TBConfNewPassword.TabIndex = 28;
            this.TBConfNewPassword.UseSystemPasswordChar = true;
            // 
            // HideTopology
            // 
            this.HideTopology.AutoSize = true;
            this.HideTopology.Location = new System.Drawing.Point(12, 344);
            this.HideTopology.Name = "HideTopology";
            this.HideTopology.Size = new System.Drawing.Size(96, 17);
            this.HideTopology.TabIndex = 30;
            this.HideTopology.Text = "HideTopology";
            this.HideTopology.Visible = false;
            // 
            // HideDevice
            // 
            this.HideDevice.AutoSize = true;
            this.HideDevice.Location = new System.Drawing.Point(12, 304);
            this.HideDevice.Name = "HideDevice";
            this.HideDevice.Size = new System.Drawing.Size(80, 17);
            this.HideDevice.TabIndex = 29;
            this.HideDevice.Text = "HideDevice";
            this.HideDevice.Visible = false;
            // 
            // HidePassword
            // 
            this.HidePassword.AutoSize = true;
            this.HidePassword.Location = new System.Drawing.Point(12, 270);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(98, 17);
            this.HidePassword.TabIndex = 31;
            this.HidePassword.Text = "HidePassword";
            this.HidePassword.Visible = false;
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(657, 496);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.HideTopology);
            this.Controls.Add(this.HideDevice);
            this.Controls.Add(this.TBConfNewPassword);
            this.Controls.Add(this.LblConfNewPassword);
            this.Controls.Add(this.TBOldPassword);
            this.Controls.Add(this.LblOldPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNewPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.LblNewPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Settings";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNewPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label LblNewPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label LblOldPassword;
        private System.Windows.Forms.TextBox TBOldPassword;
        private System.Windows.Forms.Label LblConfNewPassword;
        private System.Windows.Forms.TextBox TBConfNewPassword;
        private System.Windows.Forms.Label HideTopology;
        private System.Windows.Forms.Label HideDevice;
        private System.Windows.Forms.Label HidePassword;
    }
}