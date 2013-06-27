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
    public partial class RestoreEmployeeDetails : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet myDataSet;
        SqlCommand SqlCommand;
        SqlTransaction objTran;
        public RestoreEmployeeDetails()
        {
            InitializeComponent();
            con = new SqlConnection(GlobalClass.conn);
            con.Open();
            string sql = "SELECT EmpID FROM EmployeeDetails WHERE EmpID NOT IN('HR001') And status IS NOT NULL";
            SqlCommand = new SqlCommand(sql, con);
            SqlDataReader dr = SqlCommand.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                cbEmpID.Items.Add(dr[0]);
                count++;
            }

            dr.Close();
        }
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            cbEmpID.Text = "";
            string sql = "SELECT * FROM EmployeeDetails WHERE EmpID NOT IN('HR001') And status IS NOT NULL";

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
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string str = cbEmpID.Text;
                if (str != "")
                {
                    SqlCommand objUpdate = con.CreateCommand();
                    objUpdate.CommandText = "update EmployeeDetails set EmployeeDetails.[status]=NULL WHERE EmployeeDetails.[EmpID]='" + str + "'";
                    objUpdate.Connection = con;
                    objUpdate.Transaction = objTran;
                    int res = objUpdate.ExecuteNonQuery();
                    if (res >= 1)
                    {


                        MessageBox.Show("Employee details are restored to current employees record");


                    }
                    cbEmpID.Text = "";
                    cbEmpID.Items.Clear();
                    string sql = "SELECT EmpID FROM EmployeeDetails WHERE EmpID NOT IN('HR001') And status IS NOT NULL";
                    SqlCommand = new SqlCommand(sql, con);
                    SqlDataReader dr = SqlCommand.ExecuteReader();
                    int count = 0;
                    while (dr.Read())
                    {
                        cbEmpID.Items.Add(dr[0]);
                        count++;
                    }

                    dr.Close();
                    dataGrid1.DataSource = null;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Employee details are not restored", "Restore Employee Details Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
