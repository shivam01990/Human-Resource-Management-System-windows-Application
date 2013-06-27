namespace HumanResourceManagementSystem
{
    partial class HREmployeeSearch
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
            this.btnViewAll = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.searchradio4 = new System.Windows.Forms.RadioButton();
            this.searchradio2 = new System.Windows.Forms.RadioButton();
            this.searchradio3 = new System.Windows.Forms.RadioButton();
            this.searchradio1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(379, 246);
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
            this.btnViewAll.Location = new System.Drawing.Point(285, 246);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(88, 23);
            this.btnViewAll.TabIndex = 6;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(112, 176);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(139, 21);
            this.cmbSearch.TabIndex = 5;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(285, 21);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.PreferredColumnWidth = 100;
            this.dataGrid1.Size = new System.Drawing.Size(551, 216);
            this.dataGrid1.TabIndex = 47;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(33, 179);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 13);
            this.Label1.TabIndex = 46;
            this.Label1.Text = "Search for :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.searchradio4);
            this.GroupBox1.Controls.Add(this.searchradio2);
            this.GroupBox1.Controls.Add(this.searchradio3);
            this.GroupBox1.Controls.Add(this.searchradio1);
            this.GroupBox1.Location = new System.Drawing.Point(23, 82);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(228, 80);
            this.GroupBox1.TabIndex = 45;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search employees by :";
            // 
            // searchradio4
            // 
            this.searchradio4.AutoSize = true;
            this.searchradio4.Location = new System.Drawing.Point(133, 47);
            this.searchradio4.Name = "searchradio4";
            this.searchradio4.Size = new System.Drawing.Size(81, 17);
            this.searchradio4.TabIndex = 4;
            this.searchradio4.TabStop = true;
            this.searchradio4.Text = "Designation";
            this.searchradio4.UseVisualStyleBackColor = true;
            this.searchradio4.CheckedChanged += new System.EventHandler(this.searchradio4_CheckedChanged);
            // 
            // searchradio2
            // 
            this.searchradio2.AutoSize = true;
            this.searchradio2.Location = new System.Drawing.Point(133, 24);
            this.searchradio2.Name = "searchradio2";
            this.searchradio2.Size = new System.Drawing.Size(80, 17);
            this.searchradio2.TabIndex = 2;
            this.searchradio2.TabStop = true;
            this.searchradio2.Text = "Department";
            this.searchradio2.UseVisualStyleBackColor = true;
            this.searchradio2.CheckedChanged += new System.EventHandler(this.searchradio2_CheckedChanged);
            // 
            // searchradio3
            // 
            this.searchradio3.AutoSize = true;
            this.searchradio3.Location = new System.Drawing.Point(13, 47);
            this.searchradio3.Name = "searchradio3";
            this.searchradio3.Size = new System.Drawing.Size(85, 17);
            this.searchradio3.TabIndex = 3;
            this.searchradio3.TabStop = true;
            this.searchradio3.Text = "Employee ID";
            this.searchradio3.UseVisualStyleBackColor = true;
            this.searchradio3.CheckedChanged += new System.EventHandler(this.searchradio3_CheckedChanged);
            // 
            // searchradio1
            // 
            this.searchradio1.AutoSize = true;
            this.searchradio1.Location = new System.Drawing.Point(13, 22);
            this.searchradio1.Name = "searchradio1";
            this.searchradio1.Size = new System.Drawing.Size(73, 17);
            this.searchradio1.TabIndex = 1;
            this.searchradio1.TabStop = true;
            this.searchradio1.Text = "First name";
            this.searchradio1.UseVisualStyleBackColor = true;
            this.searchradio1.CheckedChanged += new System.EventHandler(this.searchradio1_CheckedChanged);
            // 
            // HREmployeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(848, 288);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(856, 322);
            this.MinimumSize = new System.Drawing.Size(856, 322);
            this.Name = "HREmployeeSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.DataGrid dataGrid1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton searchradio4;
        internal System.Windows.Forms.RadioButton searchradio2;
        internal System.Windows.Forms.RadioButton searchradio3;
        internal System.Windows.Forms.RadioButton searchradio1;
    }
}