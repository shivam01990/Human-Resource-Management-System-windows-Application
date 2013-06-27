namespace HumanResourceManagementSystem
{
    partial class RestoreEmployeeDetails
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.cbEmpID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(302, 352);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnViewAll.Location = new System.Drawing.Point(208, 352);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(88, 23);
            this.btnViewAll.TabIndex = 3;
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
            this.dataGrid1.Location = new System.Drawing.Point(12, 130);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.Size = new System.Drawing.Size(568, 216);
            this.dataGrid1.TabIndex = 51;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.btnRestore);
            this.GroupBox1.Controls.Add(this.cbEmpID);
            this.GroupBox1.Location = new System.Drawing.Point(25, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(179, 91);
            this.GroupBox1.TabIndex = 50;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Restore the employee details for :";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnRestore.Location = new System.Drawing.Point(42, 52);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(88, 23);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // cbEmpID
            // 
            this.cbEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpID.FormattingEnabled = true;
            this.cbEmpID.Location = new System.Drawing.Point(20, 19);
            this.cbEmpID.Name = "cbEmpID";
            this.cbEmpID.Size = new System.Drawing.Size(139, 21);
            this.cbEmpID.TabIndex = 1;
            // 
            // RestoreEmployeeDetails
            // 
            this.AcceptButton = this.btnRestore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(592, 392);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.GroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 426);
            this.MinimumSize = new System.Drawing.Size(600, 426);
            this.Name = "RestoreEmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGrid dataGrid1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ComboBox cbEmpID;
    }
}