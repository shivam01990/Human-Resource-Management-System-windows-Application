using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HumanResourceManagementSystem
{
    public partial class ViewLeaveRequest : Form
    {
        SqlConnection con;


        DataSet myDataSet;

        SqlDataAdapter da;

        SqlCommand command1;
        public ViewLeaveRequest()
        {
            InitializeComponent();
            con = new SqlConnection(GlobalClass.conn);
            con.Open();
        }
        private void ViewLeaveRequest_Load(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM LeaveDetails";
            SqlCommand SqlCommand1 = new SqlCommand(sql, con);

            da = new SqlDataAdapter();
            da.SelectCommand = SqlCommand1;
            myDataSet = new System.Data.DataSet();
            da.Fill(myDataSet, "LeaveDetails");
            dataGrid1.DataSource = myDataSet;
            dataGrid1.DataMember = myDataSet.Tables["LeaveDetails"].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
