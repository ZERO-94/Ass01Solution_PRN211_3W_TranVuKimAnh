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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkSort = new System.Windows.Forms.CheckBox();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.createMember = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(621, 223);
            this.dataGridView1.TabIndex = 0;
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
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(682, 188);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(106, 23);
            this.update.TabIndex = 2;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(682, 230);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(106, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // createMember
            // 
            this.createMember.Location = new System.Drawing.Point(682, 277);
            this.createMember.Name = "createMember";
            this.createMember.Size = new System.Drawing.Size(106, 23);
            this.createMember.TabIndex = 4;
            this.createMember.Text = "create member";
            this.createMember.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(604, 88);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(106, 23);
            this.search.TabIndex = 5;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(604, 134);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(106, 23);
            this.filter.TabIndex = 6;
            this.filter.Text = "filter";
            this.filter.UseVisualStyleBackColor = true;
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
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(33, 89);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(239, 23);
            this.tbId.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(318, 88);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(239, 23);
            this.tbName.TabIndex = 9;
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
            this.cbCity.Location = new System.Drawing.Point(33, 134);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(239, 23);
            this.cbCity.TabIndex = 10;
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
            this.cbCountry.Location = new System.Drawing.Point(318, 134);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(239, 23);
            this.cbCountry.TabIndex = 11;
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.search);
            this.Controls.Add(this.createMember);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.chkSort);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMemberManagement";
            this.Text = "frmMemberManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkSort;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button createMember;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbCountry;
    }
}
