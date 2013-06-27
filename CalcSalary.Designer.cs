namespace HumanResourceManagementSystem
{
    partial class CalcSalary
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOvertimePayments = new System.Windows.Forms.TextBox();
            this.txtOvertimeHours = new System.Windows.Forms.TextBox();
            this.txtLeaveDeduction = new System.Windows.Forms.TextBox();
            this.txtNoOfLeaves = new System.Windows.Forms.TextBox();
            this.txtFixedSalary = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leave_label = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEmpID = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 359;
            this.label7.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(105, 191);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(162, 20);
            this.txtYear.TabIndex = 8;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(105, 389);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(450, 46);
            this.txtRemarks.TabIndex = 15;
            this.txtRemarks.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnSubmit.Location = new System.Drawing.Point(251, 528);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 356;
            this.label14.Text = "Remarks";
            // 
            // txtOvertimePayments
            // 
            this.txtOvertimePayments.Enabled = false;
            this.txtOvertimePayments.Location = new System.Drawing.Point(446, 288);
            this.txtOvertimePayments.Name = "txtOvertimePayments";
            this.txtOvertimePayments.Size = new System.Drawing.Size(162, 20);
            this.txtOvertimePayments.TabIndex = 13;
            // 
            // txtOvertimeHours
            // 
            this.txtOvertimeHours.Enabled = false;
            this.txtOvertimeHours.Location = new System.Drawing.Point(105, 288);
            this.txtOvertimeHours.Name = "txtOvertimeHours";
            this.txtOvertimeHours.Size = new System.Drawing.Size(162, 20);
            this.txtOvertimeHours.TabIndex = 12;
            this.txtOvertimeHours.TextChanged += new System.EventHandler(this.txtOvertimeHours_TextChanged);
            // 
            // txtLeaveDeduction
            // 
            this.txtLeaveDeduction.Enabled = false;
            this.txtLeaveDeduction.Location = new System.Drawing.Point(446, 239);
            this.txtLeaveDeduction.Name = "txtLeaveDeduction";
            this.txtLeaveDeduction.Size = new System.Drawing.Size(162, 20);
            this.txtLeaveDeduction.TabIndex = 11;
            // 
            // txtNoOfLeaves
            // 
            this.txtNoOfLeaves.Enabled = false;
            this.txtNoOfLeaves.Location = new System.Drawing.Point(105, 239);
            this.txtNoOfLeaves.Name = "txtNoOfLeaves";
            this.txtNoOfLeaves.Size = new System.Drawing.Size(162, 20);
            this.txtNoOfLeaves.TabIndex = 10;
            this.txtNoOfLeaves.TextChanged += new System.EventHandler(this.txtNoOfLeaves_TextChanged);
            // 
            // txtFixedSalary
            // 
            this.txtFixedSalary.Enabled = false;
            this.txtFixedSalary.Location = new System.Drawing.Point(446, 35);
            this.txtFixedSalary.Name = "txtFixedSalary";
            this.txtFixedSalary.Size = new System.Drawing.Size(162, 20);
            this.txtFixedSalary.TabIndex = 3;
            this.txtFixedSalary.TextChanged += new System.EventHandler(this.txtFixedSalary_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(403, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 347;
            this.label13.Text = "Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 346;
            this.label10.Text = "Overtime Payments";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 344;
            this.label8.Text = "Overtime Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 342;
            this.label6.Text = "No. of Leaves";
            // 
            // txtBankName
            // 
            this.txtBankName.Enabled = false;
            this.txtBankName.Location = new System.Drawing.Point(105, 143);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(162, 20);
            this.txtBankName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 336;
            this.label5.Text = "Account No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 335;
            this.label3.Text = "Bank Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(376, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 332;
            this.label12.Text = "Designation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 331;
            this.label11.Text = "Department";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 341);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 337;
            this.label17.Text = "Total Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 330;
            this.label2.Text = "First Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtOvertimePayments);
            this.groupBox1.Controls.Add(this.txtOvertimeHours);
            this.groupBox1.Controls.Add(this.txtLeaveDeduction);
            this.groupBox1.Controls.Add(this.txtNoOfLeaves);
            this.groupBox1.Controls.Add(this.txtFixedSalary);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBankName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTotalSalary);
            this.groupBox1.Controls.Add(this.txtAccNo);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMonth);
            this.groupBox1.Controls.Add(this.txtDesignation);
            this.groupBox1.Controls.Add(this.txtDepartment);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.leave_label);
            this.groupBox1.Location = new System.Drawing.Point(14, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 467);
            this.groupBox1.TabIndex = 363;
            this.groupBox1.TabStop = false;
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.Enabled = false;
            this.txtTotalSalary.Location = new System.Drawing.Point(105, 338);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.Size = new System.Drawing.Size(162, 20);
            this.txtTotalSalary.TabIndex = 14;
            // 
            // txtAccNo
            // 
            this.txtAccNo.Enabled = false;
            this.txtAccNo.Location = new System.Drawing.Point(446, 143);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(162, 20);
            this.txtAccNo.TabIndex = 7;
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
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
            this.cbMonth.Location = new System.Drawing.Point(446, 191);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(162, 21);
            this.cbMonth.TabIndex = 9;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // txtDesignation
            // 
            this.txtDesignation.Enabled = false;
            this.txtDesignation.Location = new System.Drawing.Point(446, 90);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(162, 20);
            this.txtDesignation.TabIndex = 5;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Enabled = false;
            this.txtDepartment.Location = new System.Drawing.Point(105, 90);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(162, 20);
            this.txtDepartment.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Enabled = false;
            this.txtFName.Location = new System.Drawing.Point(105, 35);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(162, 20);
            this.txtFName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 325;
            this.label1.Text = "Month";
            // 
            // leave_label
            // 
            this.leave_label.AutoSize = true;
            this.leave_label.Location = new System.Drawing.Point(345, 242);
            this.leave_label.Name = "leave_label";
            this.leave_label.Size = new System.Drawing.Size(94, 13);
            this.leave_label.TabIndex = 318;
            this.leave_label.Text = "Leave Deductions";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(332, 528);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 362;
            this.label4.Text = "Select an Employee ID First:";
            // 
            // cbEmpID
            // 
            this.cbEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpID.FormattingEnabled = true;
            this.cbEmpID.Location = new System.Drawing.Point(320, 18);
            this.cbEmpID.Name = "cbEmpID";
            this.cbEmpID.Size = new System.Drawing.Size(162, 21);
            this.cbEmpID.TabIndex = 1;
            this.cbEmpID.SelectedIndexChanged += new System.EventHandler(this.cbEmpID_SelectedIndexChanged);
            // 
            // CalcSalary
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(659, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEmpID);
            this.MaximumSize = new System.Drawing.Size(667, 596);
            this.MinimumSize = new System.Drawing.Size(667, 596);
            this.Name = "CalcSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Salary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOvertimePayments;
        private System.Windows.Forms.TextBox txtOvertimeHours;
        private System.Windows.Forms.TextBox txtLeaveDeduction;
        private System.Windows.Forms.TextBox txtNoOfLeaves;
        private System.Windows.Forms.TextBox txtFixedSalary;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label leave_label;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEmpID;
    }
}