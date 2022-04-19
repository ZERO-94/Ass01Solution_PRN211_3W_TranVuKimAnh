namespace MyStoreWinApp
{
    partial class frmUpdate
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
            this.components = new System.ComponentModel.Container();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.reConfirm = new System.Windows.Forms.Label();
            this.oldPassword = new System.Windows.Forms.Label();
            this.tbReConfirm = new System.Windows.Forms.TextBox();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.changePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(72, 102);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(287, 23);
            this.tbName.TabIndex = 0;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(72, 167);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(287, 23);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "",
            "HN",
            "HCM",
            "NY",
            "CT"});
            this.cbCity.Location = new System.Drawing.Point(72, 231);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(287, 23);
            this.cbCity.TabIndex = 2;
            this.cbCity.Validating += new System.ComponentModel.CancelEventHandler(this.cbCity_Validating);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "",
            "VN",
            "USE",
            "CN",
            "JP"});
            this.cbCountry.Location = new System.Drawing.Point(72, 293);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(287, 23);
            this.cbCountry.TabIndex = 3;
            this.cbCountry.Validating += new System.ComponentModel.CancelEventHandler(this.cbCountry_Validating);
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "",
            "Admin",
            "Member"});
            this.cbRole.Location = new System.Drawing.Point(72, 353);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(287, 23);
            this.cbRole.TabIndex = 4;
            this.cbRole.Validating += new System.ComponentModel.CancelEventHandler(this.cbRole_Validating);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(72, 84);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(39, 15);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Name";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(72, 149);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 6;
            this.Email.Text = "Email";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(72, 213);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(28, 15);
            this.City.TabIndex = 7;
            this.City.Text = "City";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(72, 275);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(50, 15);
            this.Country.TabIndex = 8;
            this.Country.Text = "Country";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Role.Location = new System.Drawing.Point(72, 335);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(30, 15);
            this.Role.TabIndex = 9;
            this.Role.Text = "Role";
            // 
            // reConfirm
            // 
            this.reConfirm.AutoSize = true;
            this.reConfirm.Location = new System.Drawing.Point(449, 149);
            this.reConfirm.Name = "reConfirm";
            this.reConfirm.Size = new System.Drawing.Size(67, 15);
            this.reConfirm.TabIndex = 13;
            this.reConfirm.Text = "Re-confirm";
            // 
            // oldPassword
            // 
            this.oldPassword.AutoSize = true;
            this.oldPassword.Location = new System.Drawing.Point(449, 84);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(79, 15);
            this.oldPassword.TabIndex = 12;
            this.oldPassword.Text = "Old Password";
            // 
            // tbReConfirm
            // 
            this.tbReConfirm.Location = new System.Drawing.Point(449, 167);
            this.tbReConfirm.Name = "tbReConfirm";
            this.tbReConfirm.PasswordChar = '*';
            this.tbReConfirm.Size = new System.Drawing.Size(287, 23);
            this.tbReConfirm.TabIndex = 11;
            this.tbReConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.tbReConfirm_Validating);
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Location = new System.Drawing.Point(449, 102);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '*';
            this.tbOldPassword.Size = new System.Drawing.Size(287, 23);
            this.tbOldPassword.TabIndex = 10;
            this.tbOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbOldPassword_Validating);
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.Location = new System.Drawing.Point(449, 213);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(84, 15);
            this.newPassword.TabIndex = 15;
            this.newPassword.Text = "New Password";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(449, 231);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(287, 23);
            this.tbNewPassword.TabIndex = 14;
            this.tbNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewPassword_Validating);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(284, 397);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 16;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // changePassword
            // 
            this.changePassword.Location = new System.Drawing.Point(614, 267);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(122, 23);
            this.changePassword.TabIndex = 17;
            this.changePassword.Text = "change password";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Welcome,";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(69, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(59, 15);
            this.username.TabIndex = 19;
            this.username.Text = "username";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(698, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(90, 23);
            this.logout.TabIndex = 20;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.update);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.reConfirm);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.tbReConfirm);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Name = "frmUpdate";
            this.Text = "Update form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdate_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label reConfirm;
        private System.Windows.Forms.Label oldPassword;
        private System.Windows.Forms.TextBox tbReConfirm;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button logout;
    }
}
