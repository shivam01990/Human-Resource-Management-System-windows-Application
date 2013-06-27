namespace HumanResourceManagementSystem
{
    partial class HRDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRDepartment));
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmpSearch = new System.Windows.Forms.Button();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.btnEmpNew = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnViewAllLeaveRequests = new System.Windows.Forms.Button();
            this.btnLeaveRequest = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearchAttendance = new System.Windows.Forms.Button();
            this.btnAttReport = new System.Windows.Forms.Button();
            this.btnDailyAtt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSlipOrReport = new System.Windows.Forms.Button();
            this.btnSalReport = new System.Windows.Forms.Button();
            this.btnEmployeeAgreement = new System.Windows.Forms.Button();
            this.btnCalcSalary = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(676, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 66);
            this.label1.TabIndex = 11;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(212, 713);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(218, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 712);
            this.panel1.TabIndex = 20;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnLogout.Location = new System.Drawing.Point(24, 524);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(162, 23);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnEmpSearch);
            this.groupBox1.Controls.Add(this.btnEmpDelete);
            this.groupBox1.Controls.Add(this.btnEmpUpdate);
            this.groupBox1.Controls.Add(this.btnEmpNew);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 140);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // btnEmpSearch
            // 
            this.btnEmpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnEmpSearch.Location = new System.Drawing.Point(16, 48);
            this.btnEmpSearch.Name = "btnEmpSearch";
            this.btnEmpSearch.Size = new System.Drawing.Size(162, 23);
            this.btnEmpSearch.TabIndex = 2;
            this.btnEmpSearch.Text = "Search Employee Details";
            this.btnEmpSearch.UseVisualStyleBackColor = false;
            this.btnEmpSearch.Click += new System.EventHandler(this.btnEmpSearch_Click);
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnEmpDelete.Location = new System.Drawing.Point(16, 106);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(162, 23);
            this.btnEmpDelete.TabIndex = 4;
            this.btnEmpDelete.Text = "Delete Employee Details";
            this.btnEmpDelete.UseVisualStyleBackColor = false;
            this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnEmpUpdate.Location = new System.Drawing.Point(16, 77);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(162, 23);
            this.btnEmpUpdate.TabIndex = 3;
            this.btnEmpUpdate.Text = "Update Employee Details";
            this.btnEmpUpdate.UseVisualStyleBackColor = false;
            this.btnEmpUpdate.Click += new System.EventHandler(this.btnEmpUpdate_Click);
            // 
            // btnEmpNew
            // 
            this.btnEmpNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnEmpNew.Location = new System.Drawing.Point(16, 19);
            this.btnEmpNew.Name = "btnEmpNew";
            this.btnEmpNew.Size = new System.Drawing.Size(162, 23);
            this.btnEmpNew.TabIndex = 1;
            this.btnEmpNew.Text = "New Employee Details";
            this.btnEmpNew.UseVisualStyleBackColor = false;
            this.btnEmpNew.Click += new System.EventHandler(this.btnEmpNew_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.btnViewAllLeaveRequests);
            this.groupBox4.Controls.Add(this.btnLeaveRequest);
            this.groupBox4.Location = new System.Drawing.Point(8, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 85);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Leave Management";
            // 
            // btnViewAllLeaveRequests
            // 
            this.btnViewAllLeaveRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnViewAllLeaveRequests.Location = new System.Drawing.Point(16, 48);
            this.btnViewAllLeaveRequests.Name = "btnViewAllLeaveRequests";
            this.btnViewAllLeaveRequests.Size = new System.Drawing.Size(162, 23);
            this.btnViewAllLeaveRequests.TabIndex = 13;
            this.btnViewAllLeaveRequests.Text = "View All Leave Requests";
            this.btnViewAllLeaveRequests.UseVisualStyleBackColor = false;
            this.btnViewAllLeaveRequests.Click += new System.EventHandler(this.btnViewAllLeaveRequests_Click);
            // 
            // btnLeaveRequest
            // 
            this.btnLeaveRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnLeaveRequest.Location = new System.Drawing.Point(16, 19);
            this.btnLeaveRequest.Name = "btnLeaveRequest";
            this.btnLeaveRequest.Size = new System.Drawing.Size(162, 23);
            this.btnLeaveRequest.TabIndex = 12;
            this.btnLeaveRequest.Text = "Leave Request";
            this.btnLeaveRequest.UseVisualStyleBackColor = false;
            this.btnLeaveRequest.Click += new System.EventHandler(this.btnLeaveRequest_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.btnSearchAttendance);
            this.groupBox3.Controls.Add(this.btnAttReport);
            this.groupBox3.Controls.Add(this.btnDailyAtt);
            this.groupBox3.Location = new System.Drawing.Point(8, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 110);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time and Attendance Management";
            // 
            // btnSearchAttendance
            // 
            this.btnSearchAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnSearchAttendance.Location = new System.Drawing.Point(16, 52);
            this.btnSearchAttendance.Name = "btnSearchAttendance";
            this.btnSearchAttendance.Size = new System.Drawing.Size(162, 23);
            this.btnSearchAttendance.TabIndex = 10;
            this.btnSearchAttendance.Text = "Search Attendance Details";
            this.btnSearchAttendance.UseVisualStyleBackColor = false;
            this.btnSearchAttendance.Click += new System.EventHandler(this.btnSearchAttendance_Click);
            // 
            // btnAttReport
            // 
            this.btnAttReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnAttReport.Location = new System.Drawing.Point(16, 81);
            this.btnAttReport.Name = "btnAttReport";
            this.btnAttReport.Size = new System.Drawing.Size(162, 23);
            this.btnAttReport.TabIndex = 11;
            this.btnAttReport.Text = "Attendance Report";
            this.btnAttReport.UseVisualStyleBackColor = false;
            this.btnAttReport.Click += new System.EventHandler(this.btnAttReport_Click);
            // 
            // btnDailyAtt
            // 
            this.btnDailyAtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnDailyAtt.Location = new System.Drawing.Point(16, 19);
            this.btnDailyAtt.Name = "btnDailyAtt";
            this.btnDailyAtt.Size = new System.Drawing.Size(162, 23);
            this.btnDailyAtt.TabIndex = 9;
            this.btnDailyAtt.Text = "Daily Attendance";
            this.btnDailyAtt.UseVisualStyleBackColor = false;
            this.btnDailyAtt.Click += new System.EventHandler(this.btnDailyAtt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnSlipOrReport);
            this.groupBox2.Controls.Add(this.btnSalReport);
            this.groupBox2.Controls.Add(this.btnEmployeeAgreement);
            this.groupBox2.Controls.Add(this.btnCalcSalary);
            this.groupBox2.Location = new System.Drawing.Point(8, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 143);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payroll";
            // 
            // btnSlipOrReport
            // 
            this.btnSlipOrReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnSlipOrReport.Location = new System.Drawing.Point(16, 107);
            this.btnSlipOrReport.Name = "btnSlipOrReport";
            this.btnSlipOrReport.Size = new System.Drawing.Size(162, 23);
            this.btnSlipOrReport.TabIndex = 8;
            this.btnSlipOrReport.Text = "Get Salary Slip/Report";
            this.btnSlipOrReport.UseVisualStyleBackColor = false;
            this.btnSlipOrReport.Click += new System.EventHandler(this.btnSlipOrReport_Click);
            // 
            // btnSalReport
            // 
            this.btnSalReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnSalReport.Location = new System.Drawing.Point(16, 78);
            this.btnSalReport.Name = "btnSalReport";
            this.btnSalReport.Size = new System.Drawing.Size(162, 23);
            this.btnSalReport.TabIndex = 7;
            this.btnSalReport.Text = "Search Salary Details";
            this.btnSalReport.UseVisualStyleBackColor = false;
            this.btnSalReport.Click += new System.EventHandler(this.btnSalReport_Click);
            // 
            // btnEmployeeAgreement
            // 
            this.btnEmployeeAgreement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnEmployeeAgreement.Location = new System.Drawing.Point(16, 19);
            this.btnEmployeeAgreement.Name = "btnEmployeeAgreement";
            this.btnEmployeeAgreement.Size = new System.Drawing.Size(162, 23);
            this.btnEmployeeAgreement.TabIndex = 5;
            this.btnEmployeeAgreement.Text = "Employee Agreement";
            this.btnEmployeeAgreement.UseVisualStyleBackColor = false;
            this.btnEmployeeAgreement.Click += new System.EventHandler(this.btnEmployeeAgreement_Click);
            // 
            // btnCalcSalary
            // 
            this.btnCalcSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnCalcSalary.Location = new System.Drawing.Point(16, 48);
            this.btnCalcSalary.Name = "btnCalcSalary";
            this.btnCalcSalary.Size = new System.Drawing.Size(162, 23);
            this.btnCalcSalary.TabIndex = 6;
            this.btnCalcSalary.Text = "Calc/Get Employee Salary";
            this.btnCalcSalary.UseVisualStyleBackColor = false;
            this.btnCalcSalary.Click += new System.EventHandler(this.btnCalcSalary_Click);
            // 
            // HRDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1028, 713);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "HRDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Department";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnEmpSearch;
        internal System.Windows.Forms.Button btnEmpDelete;
        internal System.Windows.Forms.Button btnEmpUpdate;
        internal System.Windows.Forms.Button btnEmpNew;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button btnViewAllLeaveRequests;
        internal System.Windows.Forms.Button btnLeaveRequest;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btnSearchAttendance;
        internal System.Windows.Forms.Button btnAttReport;
        internal System.Windows.Forms.Button btnDailyAtt;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnSlipOrReport;
        internal System.Windows.Forms.Button btnSalReport;
        internal System.Windows.Forms.Button btnEmployeeAgreement;
        internal System.Windows.Forms.Button btnCalcSalary;

    }
}