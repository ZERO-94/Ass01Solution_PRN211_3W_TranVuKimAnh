namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.memberDataGrid = new System.Windows.Forms.DataGridView();
            this.chkSort = new System.Windows.Forms.CheckBox();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.createMember = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.searchId = new System.Windows.Forms.TextBox();
            this.searchName = new System.Windows.Forms.TextBox();
            this.searchCity = new System.Windows.Forms.ComboBox();
            this.searchCountry = new System.Windows.Forms.ComboBox();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // memberDataGrid
            // 
            this.memberDataGrid.AllowUserToAddRows = false;
            this.memberDataGrid.AllowUserToDeleteRows = false;
            this.memberDataGrid.AllowUserToOrderColumns = true;
            this.memberDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGrid.Location = new System.Drawing.Point(33, 188);
            this.memberDataGrid.MultiSelect = false;
            this.memberDataGrid.Name = "memberDataGrid";
            this.memberDataGrid.ReadOnly = true;
            this.memberDataGrid.RowTemplate.Height = 25;
            this.memberDataGrid.Size = new System.Drawing.Size(621, 223);
            this.memberDataGrid.TabIndex = 0;
            // 
            // chkSort
            // 
            this.chkSort.AutoSize = true;
            this.chkSort.Location = new System.Drawing.Point(33, 419);
            this.chkSort.Name = "chkSort";
            this.chkSort.Size = new System.Drawing.Size(146, 19);
            this.chkSort.TabIndex = 1;
            this.chkSort.Text = "I want to sort this table";
            this.chkSort.UseVisualStyleBackColor = true;
            this.chkSort.CheckedChanged += new System.EventHandler(this.chkSort_CheckedChanged);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(682, 188);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(106, 23);
            this.update.TabIndex = 2;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(682, 230);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(106, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // createMember
            // 
            this.createMember.Location = new System.Drawing.Point(682, 277);
            this.createMember.Name = "createMember";
            this.createMember.Size = new System.Drawing.Size(106, 23);
            this.createMember.TabIndex = 4;
            this.createMember.Text = "create member";
            this.createMember.UseVisualStyleBackColor = true;
            this.createMember.Click += new System.EventHandler(this.createMember_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(604, 88);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(106, 23);
            this.search.TabIndex = 5;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(604, 134);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(106, 23);
            this.filter.TabIndex = 6;
            this.filter.Text = "filter";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(682, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(106, 23);
            this.logout.TabIndex = 7;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // searchId
            // 
            this.searchId.Location = new System.Drawing.Point(33, 89);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(239, 23);
            this.searchId.TabIndex = 8;
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(318, 88);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(239, 23);
            this.searchName.TabIndex = 9;
            // 
            // searchCity
            // 
            this.searchCity.FormattingEnabled = true;
            this.searchCity.Items.AddRange(new object[] {
            "",
            "HN",
            "HCM",
            "NY",
            "CT"});
            this.searchCity.Location = new System.Drawing.Point(33, 134);
            this.searchCity.Name = "searchCity";
            this.searchCity.Size = new System.Drawing.Size(239, 23);
            this.searchCity.TabIndex = 10;
            // 
            // searchCountry
            // 
            this.searchCountry.FormattingEnabled = true;
            this.searchCountry.Items.AddRange(new object[] {
            "",
            "VN",
            "USE",
            "CN",
            "JP"});
            this.searchCountry.Location = new System.Drawing.Point(318, 134);
            this.searchCountry.Name = "searchCountry";
            this.searchCountry.Size = new System.Drawing.Size(239, 23);
            this.searchCountry.TabIndex = 11;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(65, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(59, 15);
            this.username.TabIndex = 21;
            this.username.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Welcome,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Search Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Search City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Search Country";
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchCountry);
            this.Controls.Add(this.searchCity);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.searchId);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.search);
            this.Controls.Add(this.createMember);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.chkSort);
            this.Controls.Add(this.memberDataGrid);
            this.Name = "frmMemberManagement";
            this.Text = "frmMemberManagement";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView memberDataGrid;
        private System.Windows.Forms.CheckBox chkSort;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button createMember;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.TextBox searchId;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.ComboBox searchCity;
        private System.Windows.Forms.ComboBox searchCountry;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
