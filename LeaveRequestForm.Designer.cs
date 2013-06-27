namespace HumanResourceManagementSystem
{
    partial class LeaveRequestForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbEmpID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.DateTimePicker();
            this.txtFrom = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.RichTextBox();
            this.txtMonth = new System.Windows.Forms.ComboBox();
            this.txtNODays = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(318, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 22);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbEmpID
            // 
            this.cmbEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpID.FormattingEnabled = true;
            this.cmbEmpID.Location = new System.Drawing.Point(208, 12);
            this.cmbEmpID.Name = "cmbEmpID";
            this.cmbEmpID.Size = new System.Drawing.Size(182, 21);
            this.cmbEmpID.TabIndex = 1;
            this.cmbEmpID.SelectedIndexChanged += new System.EventHandler(this.cmbEmpID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Employee ID :";
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnViewAll.Location = new System.Drawing.Point(115, 393);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 22);
            this.btnViewAll.TabIndex = 10;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.txtYear);
            this.GroupBox1.Controls.Add(this.txtTo);
            this.GroupBox1.Controls.Add(this.txtFrom);
            this.GroupBox1.Controls.Add(this.label10);
            this.GroupBox1.Controls.Add(this.txtEmpID);
            this.GroupBox1.Controls.Add(this.txtReason);
            this.GroupBox1.Controls.Add(this.txtMonth);
            this.GroupBox1.Controls.Add(this.txtNODays);
            this.GroupBox1.Controls.Add(this.txtFName);
            this.GroupBox1.Controls.Add(this.txtDept);
            this.GroupBox1.Controls.Add(this.label9);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Location = new System.Drawing.Point(17, 51);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(485, 321);
            this.GroupBox1.TabIndex = 15;
            this.GroupBox1.TabStop = false;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(344, 94);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 20);
            this.txtYear.TabIndex = 6;
            // 
            // txtTo
            // 
            this.txtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTo.Location = new System.Drawing.Point(344, 134);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(121, 20);
            this.txtTo.TabIndex = 8;
            // 
            // txtFrom
            // 
            this.txtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFrom.Location = new System.Drawing.Point(94, 135);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(121, 20);
            this.txtFrom.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Employee ID :";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(94, 14);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(121, 20);
            this.txtEmpID.TabIndex = 2;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(94, 215);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(371, 96);
            this.txtReason.TabIndex = 10;
            this.txtReason.Text = "";
            // 
            // txtMonth
            // 
            this.txtMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMonth.FormattingEnabled = true;
            this.txtMonth.Items.AddRange(new object[] {
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
            this.txtMonth.Location = new System.Drawing.Point(94, 94);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(121, 21);
            this.txtMonth.TabIndex = 5;
            // 
            // txtNODays
            // 
            this.txtNODays.Location = new System.Drawing.Point(94, 175);
            this.txtNODays.Name = "txtNODays";
            this.txtNODays.Size = new System.Drawing.Size(121, 20);
            this.txtNODays.TabIndex = 9;
            // 
            // txtFName
            // 
            this.txtFName.Enabled = false;
            this.txtFName.Location = new System.Drawing.Point(344, 14);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(121, 20);
            this.txtFName.TabIndex = 3;
            // 
            // txtDept
            // 
            this.txtDept.Enabled = false;
            this.txtDept.Location = new System.Drawing.Point(94, 54);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(121, 20);
            this.txtDept.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Reason :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "To :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "From :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. of Days :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Month :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnSubmit.Location = new System.Drawing.Point(217, 393);
            this.btnSubmit.MaximumSize = new System.Drawing.Size(75, 22);
            this.btnSubmit.MinimumSize = new System.Drawing.Size(75, 22);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 22);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // LeaveRequestForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(517, 437);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbEmpID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnSubmit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 471);
            this.MinimumSize = new System.Drawing.Size(525, 471);
            this.Name = "LeaveRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave Request Form";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.ComboBox cmbEmpID;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnViewAll;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.DateTimePicker txtTo;
        private System.Windows.Forms.DateTimePicker txtFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.RichTextBox txtReason;
        private System.Windows.Forms.ComboBox txtMonth;
        private System.Windows.Forms.TextBox txtNODays;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
    }
}