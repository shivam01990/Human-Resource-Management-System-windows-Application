namespace HumanResourceManagementSystem
{
    partial class ViewLeaveRequest
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.edit1_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(330, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(12, 69);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(65)))));
            this.dataGrid1.PreferredColumnWidth = 100;
            this.dataGrid1.Size = new System.Drawing.Size(718, 295);
            this.dataGrid1.TabIndex = 23;
            // 
            // edit1_label
            // 
            this.edit1_label.AutoSize = true;
            this.edit1_label.Location = new System.Drawing.Point(31, 34);
            this.edit1_label.Name = "edit1_label";
            this.edit1_label.Size = new System.Drawing.Size(247, 13);
            this.edit1_label.TabIndex = 22;
            this.edit1_label.Text = "The following leave applications have been made :";
            // 
            // ViewLeaveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(740, 404);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.edit1_label);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(748, 438);
            this.MinimumSize = new System.Drawing.Size(748, 438);
            this.Name = "ViewLeaveRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Leave Requests";
            this.Load += new System.EventHandler(this.ViewLeaveRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGrid dataGrid1;
        internal System.Windows.Forms.Label edit1_label;
    }
}