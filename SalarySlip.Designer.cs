namespace HumanResourceManagementSystem
{
    partial class SalarySlip
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
            this.button2 = new System.Windows.Forms.Button();
            this.rbSalaryReport = new System.Windows.Forms.RadioButton();
            this.btnSalaryReportAll = new System.Windows.Forms.Button();
            this.rbSalarySlip = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cmbEmpID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbSalarySlip = new System.Windows.Forms.RichTextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(435, 642);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbSalaryReport
            // 
            this.rbSalaryReport.AutoSize = true;
            this.rbSalaryReport.Location = new System.Drawing.Point(137, 28);
            this.rbSalaryReport.Name = "rbSalaryReport";
            this.rbSalaryReport.Size = new System.Drawing.Size(109, 17);
            this.rbSalaryReport.TabIndex = 5;
            this.rbSalaryReport.TabStop = true;
            this.rbSalaryReport.Text = "Get Salary Report";
            this.rbSalaryReport.UseVisualStyleBackColor = true;
            this.rbSalaryReport.CheckedChanged += new System.EventHandler(this.rbSalaryReport_CheckedChanged);
            // 
            // btnSalaryReportAll
            // 
            this.btnSalaryReportAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnSalaryReportAll.Location = new System.Drawing.Point(294, 642);
            this.btnSalaryReportAll.Name = "btnSalaryReportAll";
            this.btnSalaryReportAll.Size = new System.Drawing.Size(135, 28);
            this.btnSalaryReportAll.TabIndex = 7;
            this.btnSalaryReportAll.Text = "Report Of All Employees";
            this.btnSalaryReportAll.UseVisualStyleBackColor = false;
            this.btnSalaryReportAll.Click += new System.EventHandler(this.btnSalaryReportAll_Click);
            // 
            // rbSalarySlip
            // 
            this.rbSalarySlip.AutoSize = true;
            this.rbSalarySlip.Location = new System.Drawing.Point(16, 28);
            this.rbSalarySlip.Name = "rbSalarySlip";
            this.rbSalarySlip.Size = new System.Drawing.Size(94, 17);
            this.rbSalarySlip.TabIndex = 4;
            this.rbSalarySlip.TabStop = true;
            this.rbSalarySlip.Text = "Get Salary Slip";
            this.rbSalarySlip.UseVisualStyleBackColor = true;
            this.rbSalarySlip.CheckedChanged += new System.EventHandler(this.rbSalarySlip_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSalaryReport);
            this.groupBox2.Controls.Add(this.rbSalarySlip);
            this.groupBox2.Location = new System.Drawing.Point(16, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 63);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salary Details";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // cmbEmpID
            // 
            this.cmbEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpID.FormattingEnabled = true;
            this.cmbEmpID.Location = new System.Drawing.Point(110, 86);
            this.cmbEmpID.Name = "cmbEmpID";
            this.cmbEmpID.Size = new System.Drawing.Size(136, 21);
            this.cmbEmpID.TabIndex = 3;
            this.cmbEmpID.SelectedIndexChanged += new System.EventHandler(this.cmbEmpID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee ID :";
            // 
            // rtbSalarySlip
            // 
            this.rtbSalarySlip.Enabled = false;
            this.rtbSalarySlip.Location = new System.Drawing.Point(294, 12);
            this.rtbSalarySlip.Name = "rtbSalarySlip";
            this.rtbSalarySlip.Size = new System.Drawing.Size(499, 562);
            this.rtbSalarySlip.TabIndex = 10;
            this.rtbSalarySlip.Text = "";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(110, 18);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(136, 20);
            this.txtYear.TabIndex = 1;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEmpID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Location = new System.Drawing.Point(16, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 123);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Details for:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Month";
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
            this.cmbMonth.Location = new System.Drawing.Point(110, 52);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(136, 21);
            this.cmbMonth.TabIndex = 2;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnPrint.Location = new System.Drawing.Point(515, 607);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 28);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // SalarySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(819, 682);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSalaryReportAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtbSalarySlip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.MaximumSize = new System.Drawing.Size(827, 716);
            this.MinimumSize = new System.Drawing.Size(827, 716);
            this.Name = "SalarySlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Salary Slip/Report";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbSalaryReport;
        private System.Windows.Forms.Button btnSalaryReportAll;
        private System.Windows.Forms.RadioButton rbSalarySlip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox cmbEmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbSalarySlip;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}