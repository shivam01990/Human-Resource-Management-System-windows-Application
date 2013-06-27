using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResourceManagementSystem
{
    public partial class ViewAttendanceReport : Form
    {
        public ViewAttendanceReport()
        {
            InitializeComponent();
        }

        private void ViewAttendanceReport_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.RefreshReport();
        }
    }
}
