namespace HumanResourceManagementSystem
{
    partial class HRAddNewEmployee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dob_text1 = new System.Windows.Forms.DateTimePicker();
            this.desig_text1 = new System.Windows.Forms.ComboBox();
            this.dept_text1 = new System.Windows.Forms.ComboBox();
            this.doj_text1 = new System.Windows.Forms.DateTimePicker();
            this.email_text1 = new System.Windows.Forms.TextBox();
            this.email_label1 = new System.Windows.Forms.Label();
            this.sex_text1 = new System.Windows.Forms.ComboBox();
            this.education_text1 = new System.Windows.Forms.TextBox();
            this.phone_text1 = new System.Windows.Forms.TextBox();
            this.cell_text1 = new System.Windows.Forms.TextBox();
            this.address_text1 = new System.Windows.Forms.TextBox();
            this.empswd_text1 = new System.Windows.Forms.TextBox();
            this.empdet_text1 = new System.Windows.Forms.TextBox();
            this.lastname_text1 = new System.Windows.Forms.TextBox();
            this.middlename_text1 = new System.Windows.Forms.TextBox();
            this.firstname_text1 = new System.Windows.Forms.TextBox();
            this.doj_label1 = new System.Windows.Forms.Label();
            this.desig_label1 = new System.Windows.Forms.Label();
            this.education_label1 = new System.Windows.Forms.Label();
            this.sex_label1 = new System.Windows.Forms.Label();
            this.cell_label1 = new System.Windows.Forms.Label();
            this.phone_label1 = new System.Windows.Forms.Label();
            this.address_label1 = new System.Windows.Forms.Label();
            this.Dept_label1 = new System.Windows.Forms.Label();
            this.empswd_label1 = new System.Windows.Forms.Label();
            this.empid_label1 = new System.Windows.Forms.Label();
            this.lastname_label1 = new System.Windows.Forms.Label();
            this.middlename_label1 = new System.Windows.Forms.Label();
            this.firstname_label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dob_text1);
            this.groupBox1.Controls.Add(this.desig_text1);
            this.groupBox1.Controls.Add(this.dept_text1);
            this.groupBox1.Controls.Add(this.doj_text1);
            this.groupBox1.Controls.Add(this.email_text1);
            this.groupBox1.Controls.Add(this.email_label1);
            this.groupBox1.Controls.Add(this.sex_text1);
            this.groupBox1.Controls.Add(this.education_text1);
            this.groupBox1.Controls.Add(this.phone_text1);
            this.groupBox1.Controls.Add(this.cell_text1);
            this.groupBox1.Controls.Add(this.address_text1);
            this.groupBox1.Controls.Add(this.empswd_text1);
            this.groupBox1.Controls.Add(this.empdet_text1);
            this.groupBox1.Controls.Add(this.lastname_text1);
            this.groupBox1.Controls.Add(this.middlename_text1);
            this.groupBox1.Controls.Add(this.firstname_text1);
            this.groupBox1.Controls.Add(this.doj_label1);
            this.groupBox1.Controls.Add(this.desig_label1);
            this.groupBox1.Controls.Add(this.education_label1);
            this.groupBox1.Controls.Add(this.sex_label1);
            this.groupBox1.Controls.Add(this.cell_label1);
            this.groupBox1.Controls.Add(this.phone_label1);
            this.groupBox1.Controls.Add(this.address_label1);
            this.groupBox1.Controls.Add(this.Dept_label1);
            this.groupBox1.Controls.Add(this.empswd_label1);
            this.groupBox1.Controls.Add(this.empid_label1);
            this.groupBox1.Controls.Add(this.lastname_label1);
            this.groupBox1.Controls.Add(this.middlename_label1);
            this.groupBox1.Controls.Add(this.firstname_label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 382);
            this.groupBox1.TabIndex = 263;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 260;
            this.label1.Text = "Date Of Birth :";
            // 
            // dob_text1
            // 
            this.dob_text1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_text1.Location = new System.Drawing.Point(99, 181);
            this.dob_text1.Name = "dob_text1";
            this.dob_text1.Size = new System.Drawing.Size(207, 20);
            this.dob_text1.TabIndex = 8;
            // 
            // desig_text1
            // 
            this.desig_text1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desig_text1.FormattingEnabled = true;
            this.desig_text1.Items.AddRange(new object[] {
            "Head",
            "Senior Manager",
            "Assistant Manager",
            "Executive",
            "Programmer",
            "Developer",
            "Project Leader",
            "Sales Officer",
            "Product Trainer",
            "Sales Trainer",
            "Others"});
            this.desig_text1.Location = new System.Drawing.Point(99, 347);
            this.desig_text1.Name = "desig_text1";
            this.desig_text1.Size = new System.Drawing.Size(207, 21);
            this.desig_text1.TabIndex = 14;
            // 
            // dept_text1
            // 
            this.dept_text1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept_text1.FormattingEnabled = true;
            this.dept_text1.Items.AddRange(new object[] {
            "Marketing",
            "Production",
            "Technology",
            "Finance",
            "HR",
            "Education",
            "Customer Relationship Management"});
            this.dept_text1.Location = new System.Drawing.Point(543, 74);
            this.dept_text1.Name = "dept_text1";
            this.dept_text1.Size = new System.Drawing.Size(100, 21);
            this.dept_text1.TabIndex = 6;
            // 
            // doj_text1
            // 
            this.doj_text1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.doj_text1.Location = new System.Drawing.Point(437, 350);
            this.doj_text1.Name = "doj_text1";
            this.doj_text1.Size = new System.Drawing.Size(207, 20);
            this.doj_text1.TabIndex = 15;
            // 
            // email_text1
            // 
            this.email_text1.Location = new System.Drawing.Point(437, 293);
            this.email_text1.Name = "email_text1";
            this.email_text1.Size = new System.Drawing.Size(206, 20);
            this.email_text1.TabIndex = 13;
            // 
            // email_label1
            // 
            this.email_label1.AutoSize = true;
            this.email_label1.Location = new System.Drawing.Point(385, 296);
            this.email_label1.Name = "email_label1";
            this.email_label1.Size = new System.Drawing.Size(38, 13);
            this.email_label1.TabIndex = 258;
            this.email_label1.Text = "Email :";
            // 
            // sex_text1
            // 
            this.sex_text1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex_text1.FormattingEnabled = true;
            this.sex_text1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sex_text1.Location = new System.Drawing.Point(437, 181);
            this.sex_text1.Name = "sex_text1";
            this.sex_text1.Size = new System.Drawing.Size(206, 21);
            this.sex_text1.TabIndex = 9;
            // 
            // education_text1
            // 
            this.education_text1.Location = new System.Drawing.Point(99, 293);
            this.education_text1.Name = "education_text1";
            this.education_text1.Size = new System.Drawing.Size(207, 20);
            this.education_text1.TabIndex = 12;
            // 
            // phone_text1
            // 
            this.phone_text1.Location = new System.Drawing.Point(99, 237);
            this.phone_text1.Name = "phone_text1";
            this.phone_text1.Size = new System.Drawing.Size(207, 20);
            this.phone_text1.TabIndex = 10;
            // 
            // cell_text1
            // 
            this.cell_text1.Location = new System.Drawing.Point(437, 238);
            this.cell_text1.Name = "cell_text1";
            this.cell_text1.Size = new System.Drawing.Size(206, 20);
            this.cell_text1.TabIndex = 11;
            // 
            // address_text1
            // 
            this.address_text1.Location = new System.Drawing.Point(99, 128);
            this.address_text1.Name = "address_text1";
            this.address_text1.Size = new System.Drawing.Size(544, 20);
            this.address_text1.TabIndex = 7;
            // 
            // empswd_text1
            // 
            this.empswd_text1.Location = new System.Drawing.Point(319, 74);
            this.empswd_text1.Name = "empswd_text1";
            this.empswd_text1.PasswordChar = '*';
            this.empswd_text1.Size = new System.Drawing.Size(100, 20);
            this.empswd_text1.TabIndex = 5;
            // 
            // empdet_text1
            // 
            this.empdet_text1.Location = new System.Drawing.Point(99, 74);
            this.empdet_text1.Name = "empdet_text1";
            this.empdet_text1.Size = new System.Drawing.Size(100, 20);
            this.empdet_text1.TabIndex = 4;
            this.empdet_text1.TextChanged += new System.EventHandler(this.empdet_text1_TextChanged);
            // 
            // lastname_text1
            // 
            this.lastname_text1.Location = new System.Drawing.Point(543, 20);
            this.lastname_text1.Name = "lastname_text1";
            this.lastname_text1.Size = new System.Drawing.Size(101, 20);
            this.lastname_text1.TabIndex = 3;
            // 
            // middlename_text1
            // 
            this.middlename_text1.Location = new System.Drawing.Point(319, 20);
            this.middlename_text1.Name = "middlename_text1";
            this.middlename_text1.Size = new System.Drawing.Size(100, 20);
            this.middlename_text1.TabIndex = 2;
            // 
            // firstname_text1
            // 
            this.firstname_text1.AcceptsTab = true;
            this.firstname_text1.Location = new System.Drawing.Point(99, 20);
            this.firstname_text1.Name = "firstname_text1";
            this.firstname_text1.Size = new System.Drawing.Size(100, 20);
            this.firstname_text1.TabIndex = 1;
            // 
            // doj_label1
            // 
            this.doj_label1.AutoSize = true;
            this.doj_label1.Location = new System.Drawing.Point(339, 350);
            this.doj_label1.Name = "doj_label1";
            this.doj_label1.Size = new System.Drawing.Size(84, 13);
            this.doj_label1.TabIndex = 255;
            this.doj_label1.Text = "Date of Joining :";
            // 
            // desig_label1
            // 
            this.desig_label1.AutoSize = true;
            this.desig_label1.Location = new System.Drawing.Point(16, 350);
            this.desig_label1.Name = "desig_label1";
            this.desig_label1.Size = new System.Drawing.Size(69, 13);
            this.desig_label1.TabIndex = 254;
            this.desig_label1.Text = "Designation :";
            // 
            // education_label1
            // 
            this.education_label1.AutoSize = true;
            this.education_label1.Location = new System.Drawing.Point(24, 296);
            this.education_label1.Name = "education_label1";
            this.education_label1.Size = new System.Drawing.Size(64, 13);
            this.education_label1.TabIndex = 252;
            this.education_label1.Text = "Education : ";
            // 
            // sex_label1
            // 
            this.sex_label1.AutoSize = true;
            this.sex_label1.Location = new System.Drawing.Point(392, 184);
            this.sex_label1.Name = "sex_label1";
            this.sex_label1.Size = new System.Drawing.Size(31, 13);
            this.sex_label1.TabIndex = 251;
            this.sex_label1.Text = "Sex :";
            // 
            // cell_label1
            // 
            this.cell_label1.AutoSize = true;
            this.cell_label1.Location = new System.Drawing.Point(393, 241);
            this.cell_label1.Name = "cell_label1";
            this.cell_label1.Size = new System.Drawing.Size(30, 13);
            this.cell_label1.TabIndex = 250;
            this.cell_label1.Text = "Cell :";
            // 
            // phone_label1
            // 
            this.phone_label1.AutoSize = true;
            this.phone_label1.Location = new System.Drawing.Point(11, 241);
            this.phone_label1.Name = "phone_label1";
            this.phone_label1.Size = new System.Drawing.Size(75, 13);
            this.phone_label1.TabIndex = 249;
            this.phone_label1.Text = "Home Phone :";
            // 
            // address_label1
            // 
            this.address_label1.AutoSize = true;
            this.address_label1.Location = new System.Drawing.Point(32, 131);
            this.address_label1.Name = "address_label1";
            this.address_label1.Size = new System.Drawing.Size(54, 13);
            this.address_label1.TabIndex = 248;
            this.address_label1.Text = " Address :";
            // 
            // Dept_label1
            // 
            this.Dept_label1.AutoSize = true;
            this.Dept_label1.Location = new System.Drawing.Point(463, 77);
            this.Dept_label1.Name = "Dept_label1";
            this.Dept_label1.Size = new System.Drawing.Size(68, 13);
            this.Dept_label1.TabIndex = 247;
            this.Dept_label1.Text = "Department :";
            // 
            // empswd_label1
            // 
            this.empswd_label1.AutoSize = true;
            this.empswd_label1.Location = new System.Drawing.Point(247, 77);
            this.empswd_label1.Name = "empswd_label1";
            this.empswd_label1.Size = new System.Drawing.Size(59, 13);
            this.empswd_label1.TabIndex = 246;
            this.empswd_label1.Text = "Password :";
            // 
            // empid_label1
            // 
            this.empid_label1.AutoSize = true;
            this.empid_label1.Location = new System.Drawing.Point(11, 77);
            this.empid_label1.Name = "empid_label1";
            this.empid_label1.Size = new System.Drawing.Size(73, 13);
            this.empid_label1.TabIndex = 245;
            this.empid_label1.Text = "Employee ID :";
            // 
            // lastname_label1
            // 
            this.lastname_label1.AutoSize = true;
            this.lastname_label1.Location = new System.Drawing.Point(467, 23);
            this.lastname_label1.Name = "lastname_label1";
            this.lastname_label1.Size = new System.Drawing.Size(64, 13);
            this.lastname_label1.TabIndex = 244;
            this.lastname_label1.Text = "Last Name :";
            // 
            // middlename_label1
            // 
            this.middlename_label1.AutoSize = true;
            this.middlename_label1.Location = new System.Drawing.Point(231, 23);
            this.middlename_label1.Name = "middlename_label1";
            this.middlename_label1.Size = new System.Drawing.Size(75, 13);
            this.middlename_label1.TabIndex = 243;
            this.middlename_label1.Text = "Middle Name :";
            // 
            // firstname_label1
            // 
            this.firstname_label1.AutoSize = true;
            this.firstname_label1.Location = new System.Drawing.Point(23, 23);
            this.firstname_label1.Name = "firstname_label1";
            this.firstname_label1.Size = new System.Drawing.Size(63, 13);
            this.firstname_label1.TabIndex = 242;
            this.firstname_label1.Text = "First Name :";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(349, 400);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.add.Location = new System.Drawing.Point(268, 400);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 16;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // HRAddNewEmployee
            // 
            this.AcceptButton = this.add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(702, 440);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.add);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 474);
            this.MinimumSize = new System.Drawing.Size(710, 474);
            this.Name = "HRAddNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker dob_text1;
        internal System.Windows.Forms.ComboBox desig_text1;
        internal System.Windows.Forms.ComboBox dept_text1;
        internal System.Windows.Forms.DateTimePicker doj_text1;
        internal System.Windows.Forms.TextBox email_text1;
        internal System.Windows.Forms.Label email_label1;
        internal System.Windows.Forms.ComboBox sex_text1;
        internal System.Windows.Forms.TextBox education_text1;
        internal System.Windows.Forms.TextBox phone_text1;
        internal System.Windows.Forms.TextBox cell_text1;
        internal System.Windows.Forms.TextBox address_text1;
        internal System.Windows.Forms.TextBox empswd_text1;
        internal System.Windows.Forms.TextBox empdet_text1;
        internal System.Windows.Forms.TextBox lastname_text1;
        internal System.Windows.Forms.TextBox middlename_text1;
        internal System.Windows.Forms.TextBox firstname_text1;
        internal System.Windows.Forms.Label doj_label1;
        internal System.Windows.Forms.Label desig_label1;
        internal System.Windows.Forms.Label education_label1;
        internal System.Windows.Forms.Label sex_label1;
        internal System.Windows.Forms.Label cell_label1;
        internal System.Windows.Forms.Label phone_label1;
        internal System.Windows.Forms.Label address_label1;
        internal System.Windows.Forms.Label Dept_label1;
        internal System.Windows.Forms.Label empswd_label1;
        internal System.Windows.Forms.Label empid_label1;
        internal System.Windows.Forms.Label lastname_label1;
        internal System.Windows.Forms.Label middlename_label1;
        internal System.Windows.Forms.Label firstname_label1;
        internal System.Windows.Forms.Button closeButton;
        internal System.Windows.Forms.Button add;
    }
}