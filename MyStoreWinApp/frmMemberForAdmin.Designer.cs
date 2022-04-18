namespace MyStoreWinApp
{
    partial class frmMemberForAdmin
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
            this.btnOk = new System.Windows.Forms.Button();
            this.Role = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbOperation = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(375, 415);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 27;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Role.Location = new System.Drawing.Point(130, 301);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(30, 15);
            this.Role.TabIndex = 26;
            this.Role.Text = "Role";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(130, 251);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(50, 15);
            this.Country.TabIndex = 25;
            this.Country.Text = "Country";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(130, 202);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(28, 15);
            this.City.TabIndex = 24;
            this.City.Text = "City";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(130, 152);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 23;
            this.Email.Text = "Email";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(130, 99);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(39, 15);
            this.lbName.TabIndex = 22;
            this.lbName.Text = "Name";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "",
            "Admin",
            "Member"});
            this.cbRole.Location = new System.Drawing.Point(130, 319);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(287, 23);
            this.cbRole.TabIndex = 21;
            this.cbRole.Validating += new System.ComponentModel.CancelEventHandler(this.cbRole_Validating);
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
            this.cbCountry.Location = new System.Drawing.Point(130, 269);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(287, 23);
            this.cbCountry.TabIndex = 20;
            this.cbCountry.Validating += new System.ComponentModel.CancelEventHandler(this.cbCountry_Validating);
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
            this.cbCity.Location = new System.Drawing.Point(130, 220);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(287, 23);
            this.cbCity.TabIndex = 19;
            this.cbCity.Validating += new System.ComponentModel.CancelEventHandler(this.cbCity_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(130, 170);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(287, 23);
            this.tbEmail.TabIndex = 18;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(130, 117);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(287, 23);
            this.tbName.TabIndex = 17;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(456, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(130, 48);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 15);
            this.lbId.TabIndex = 30;
            this.lbId.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(130, 66);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(287, 23);
            this.tbId.TabIndex = 29;
            this.tbId.Validating += new System.ComponentModel.CancelEventHandler(this.tbId_Validating);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(130, 356);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 32;
            this.lbPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(130, 374);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(287, 23);
            this.tbPassword.TabIndex = 31;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Location = new System.Drawing.Point(12, 9);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(60, 15);
            this.lbOperation.TabIndex = 33;
            this.lbOperation.Text = "Operation";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMemberForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.lbOperation);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
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
            this.Name = "frmMemberForAdmin";
            this.Text = "frmMemberForAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMemberForAdmin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbOperation;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
