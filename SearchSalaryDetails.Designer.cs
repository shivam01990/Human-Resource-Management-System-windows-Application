namespace HumanResourceManagementSystem
{
    partial class SearchSalaryDetails
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.rbEmpName = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAllEmployees = new System.Windows.Forms.Button();
            this.rbEmpID = new System.Windows.Forms.RadioButton();
            this.btnSlipOrReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(261, 12);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.PreferredColumnWidth = 100;
            this.dataGrid1.Size = new System.Drawing.Size(657, 288);
            this.dataGrid1.TabIndex = 75;
            // 
            // rbEmpName
            // 
            this.rbEmpName.AutoSize = true;
            this.rbEmpName.Location = new System.Drawing.Point(13, 19);
            this.rbEmpName.Name = "rbEmpName";
            this.rbEmpName.Size = new System.Drawing.Size(102, 17);
            this.rbEmpName.TabIndex = 3;
            this.rbEmpName.TabStop = true;
            this.rbEmpName.Text = "Employee Name";
            this.rbEmpName.UseVisualStyleBackColor = true;
            this.rbEmpName.CheckedChanged += new System.EventHandler(this.rbEmpName_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(662, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAllEmployees
            // 
            this.btnAllEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnAllEmployees.Location = new System.Drawing.Point(526, 308);
            this.btnAllEmployees.Name = "btnAllEmployees";
            this.btnAllEmployees.Size = new System.Drawing.Size(130, 23);
            this.btnAllEmployees.TabIndex = 7;
            this.btnAllEmployees.Text = "Report of All Employees";
            this.btnAllEmployees.UseVisualStyleBackColor = false;
            this.btnAllEmployees.Click += new System.EventHandler(this.btnAllEmployees_Click);
            // 
            // rbEmpID
            // 
            this.rbEmpID.AutoSize = true;
            this.rbEmpID.Location = new System.Drawing.Point(145, 19);
            this.rbEmpID.Name = "rbEmpID";
            this.rbEmpID.Size = new System.Drawing.Size(85, 17);
            this.rbEmpID.TabIndex = 4;
            this.rbEmpID.TabStop = true;
            this.rbEmpID.Text = "Employee ID";
            this.rbEmpID.UseVisualStyleBackColor = true;
            this.rbEmpID.CheckedChanged += new System.EventHandler(this.rbEmpID_CheckedChanged);
            // 
            // btnSlipOrReport
            // 
            this.btnSlipOrReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnSlipOrReport.Location = new System.Drawing.Point(409, 308);
            this.btnSlipOrReport.Name = "btnSlipOrReport";
            this.btnSlipOrReport.Size = new System.Drawing.Size(111, 23);
            this.btnSlipOrReport.TabIndex = 6;
            this.btnSlipOrReport.Text = "Salary Slip/ Report";
            this.btnSlipOrReport.UseVisualStyleBackColor = false;
            this.btnSlipOrReport.Click += new System.EventHandler(this.btnSlipOrReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Search for :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbEmpID);
            this.groupBox2.Controls.Add(this.rbEmpName);
            this.groupBox2.Location = new System.Drawing.Point(13, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 45);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Year :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
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
            this.cmbMonth.Location = new System.Drawing.Point(59, 58);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(171, 21);
            this.cmbMonth.TabIndex = 2;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(59, 20);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(171, 20);
            this.txtYear.TabIndex = 1;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(72, 189);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(171, 21);
            this.cmbSearch.TabIndex = 5;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 94);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Salary Details by :";
            // 
            // SearchSalaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(930, 342);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAllEmployees);
            this.Controls.Add(this.btnSlipOrReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(938, 376);
            this.MinimumSize = new System.Drawing.Size(938, 376);
            this.Name = "SearchSalaryDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Salary Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.RadioButton rbEmpName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAllEmployees;
        private System.Windows.Forms.RadioButton rbEmpID;
        private System.Windows.Forms.Button btnSlipOrReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}