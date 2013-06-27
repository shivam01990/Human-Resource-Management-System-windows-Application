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
    public partial class HREmployeeSearch : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet myDataSet;
        string search;
        public HREmployeeSearch()
        {
            InitializeComponent();
            con = new SqlConnection(GlobalClass.conn);
            con.Open();
        }
        private void searchradio1_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid1.DataSource = null;
            cmbSearch.Text = "";
            search = "FName";
            cmbSearch.Items.Clear();
            string sql;
            if (GlobalClass.EmpID == "admin")
            {
                sql = "SELECT FName FROM EmployeeDetails";
            }
            else
            {
                sql = "select FName FROM EmployeeDetails where EmpID NOT IN('HR001')";
            }
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "EmployeeDetails");

            int index = 0;
            for (index = 0; index < ds.Tables[0].Rows.Count; index++)
            {
                cmbSearch.Items.Add(ds.Tables[0].Rows[index][0]);
            }

        }

        private void searchradio2_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid1.DataSource = null;
            cmbSearch.Text = "";

            search = "Department";
            cmbSearch.Items.Clear();
            cmbSearch.Items.Add("marketing");
            cmbSearch.Items.Add("production");
            cmbSearch.Items.Add("technology");
            cmbSearch.Items.Add("finance");
            cmbSearch.Items.Add("HR");
            cmbSearch.Items.Add("education");
            cmbSearch.Items.Add("customer relationship management");

        }

        private void searchradio3_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid1.DataSource = null;
            cmbSearch.Text = "";
            search = "EmpID";
            cmbSearch.Items.Clear();
            string sql;
            if (GlobalClass.EmpID == "admin")
            {
                sql = "SELECT EmpID FROM EmployeeDetails";
            }
            else
            {
                sql = "select EmpID FROM EmployeeDetails where EmpID NOT IN('HR001')";
            }
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "EmployeeDetails");

            int index = 0;
            for (index = 0; index < ds.Tables[0].Rows.Count; index++)
            {
                cmbSearch.Items.Add(ds.Tables[0].Rows[index][0]);
            }

        }

        private void searchradio4_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid1.DataSource = null;
            cmbSearch.Text = "";
            search = "Designation";
            cmbSearch.Items.Clear();
            cmbSearch.Items.Add("head");
            cmbSearch.Items.Add("senior manager");
            cmbSearch.Items.Add("assistant manager");
            cmbSearch.Items.Add("executive");
            cmbSearch.Items.Add("programmer");
            cmbSearch.Items.Add("developer");
            cmbSearch.Items.Add("project leader");
            cmbSearch.Items.Add("sales officer");
            cmbSearch.Items.Add("product trainer");
            cmbSearch.Items.Add("sales trainer");
            cmbSearch.Items.Add("others");

        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string sql;
                if (GlobalClass.EmpID == "admin")
                {
                    sql = "SELECT * FROM EmployeeDetails WHERE " + search + "=@loginname";
                }
                else
                {
                    sql = "SELECT * FROM EmployeeDetails WHERE " + search + "=@loginname AND EmpID!='HR001'";
                }


                SqlCommand SqlCommand1 = con.CreateCommand();
                SqlCommand1.CommandText = sql;
                int res;
                SqlCommand1.Parameters.Add("@loginname", SqlDbType.VarChar, 100);
                SqlCommand1.Parameters[0].Value = cmbSearch.SelectedItem;
                da = new SqlDataAdapter();
                da.SelectCommand = SqlCommand1;
                myDataSet = new System.Data.DataSet();
                res = da.Fill(myDataSet, "EmployeeDetails");

                if (res >= 1)
                {
                    dataGrid1.DataSource = myDataSet;
                    dataGrid1.DataMember = myDataSet.Tables["EmployeeDetails"].ToString();


                }
                else
                {
                    MessageBox.Show("No record found");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            cmbSearch.Text = "";
            searchradio1.Checked = false;
            searchradio2.Checked = false;
            searchradio3.Checked = false;
            searchradio4.Checked = false;
            string sql;
            if (GlobalClass.EmpID == "admin")
            {
                sql = "SELECT * FROM EmployeeDetails";
            }
            else
            {
                sql = "SELECT * FROM EmployeeDetails WHERE EmpID NOT IN('HR001')";
            }

            SqlCommand SqlCommand1 = new SqlCommand(sql, con);

            da = new SqlDataAdapter();
            da.SelectCommand = SqlCommand1;
            myDataSet = new System.Data.DataSet();
            da.Fill(myDataSet, "EmployeeDetails");
            dataGrid1.DataSource = myDataSet;
            dataGrid1.DataMember = myDataSet.Tables["EmployeeDetails"].ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
