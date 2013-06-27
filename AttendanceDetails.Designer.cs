namespace HumanResourceManagementSystem
{
    partial class AttendanceDetails
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchradio2 = new System.Windows.Forms.RadioButton();
            this.searchradio1 = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchradio2);
            this.groupBox2.Controls.Add(this.searchradio1);
            this.groupBox2.Location = new System.Drawing.Point(16, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 51);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category";
            // 
            // searchradio2
            // 
            this.searchradio2.AutoSize = true;
            this.searchradio2.Location = new System.Drawing.Point(119, 19);
            this.searchradio2.Name = "searchradio2";
            this.searchradio2.Size = new System.Drawing.Size(85, 17);
            this.searchradio2.TabIndex = 4;
            this.searchradio2.TabStop = true;
            this.searchradio2.Text = "Employee ID";
            this.searchradio2.UseVisualStyleBackColor = true;
            this.searchradio2.CheckedChanged += new System.EventHandler(this.searchradio2_CheckedChanged);
            // 
            // searchradio1
            // 
            this.searchradio1.AutoSize = true;
            this.searchradio1.Location = new System.Drawing.Point(18, 19);
            this.searchradio1.Name = "searchradio1";
            this.searchradio1.Size = new System.Drawing.Size(73, 17);
            this.searchradio1.TabIndex = 3;
            this.searchradio1.TabStop = true;
            this.searchradio1.Text = "First name";
            this.searchradio1.UseVisualStyleBackColor = true;
            this.searchradio1.CheckedChanged += new System.EventHandler(this.searchradio1_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(378, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnViewAll.Location = new System.Drawing.Point(284, 260);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(88, 23);
            this.btnViewAll.TabIndex = 6;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(263, 24);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.PreferredColumnWidth = 100;
            this.dataGrid1.Size = new System.Drawing.Size(551, 216);
            this.dataGrid1.TabIndex = 75;
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(99, 196);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 21);
            this.cmbSearch.TabIndex = 5;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(31, 199);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 13);
            this.Label1.TabIndex = 74;
            this.Label1.Text = "Search for :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.txtYear);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.cmbMonth);
            this.GroupBox1.Location = new System.Drawing.Point(16, 43);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(228, 82);
            this.GroupBox1.TabIndex = 73;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search Attendance Details by :";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(83, 19);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 20);
            this.txtYear.TabIndex = 1;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Year :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Month :";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(83, 48);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbMonth.TabIndex = 2;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // AttendanceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(821, 314);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GroupBox1);
            this.MaximumSize = new System.Drawing.Size(829, 348);
            this.MinimumSize = new System.Drawing.Size(829, 348);
            this.Name = "AttendanceDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Attendance Details";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.RadioButton searchradio2;
        internal System.Windows.Forms.RadioButton searchradio1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.ComboBox cmbSearch;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMonth;
    }
}