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
    public partial class AttendanceDetails : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet myDataSet;
        string search;
        public AttendanceDetails()
        {
            InitializeComponent();
            con = new SqlConnection(GlobalClass.conn);
            con.Open();
        }
        private void searchradio1_CheckedChanged(object sender, EventArgs e)
        {
            if (searchradio1.Checked == true)
            {
                if (txtYear.Text == "" && cmbMonth.Text == "")
                {
                    MessageBox.Show("Enter a year or select a month or both");
                }
                else
                {
                    cmbSearch.Text = "";
                    dataGrid1.DataSource = null;
                    search = "FName";
                    cmbSearch.Items.Clear();

                    int count = 0;


                    string sql = "SELECT FName FROM EmployeeSalaryAgreement WHERE EmpID NOT IN('HR001')";
                    SqlCommand SqlCommand1 = new SqlCommand(sql, con);
                    SqlDataReader dr = SqlCommand1.ExecuteReader();
                    while (dr.Read())
                    {
                        cmbSearch.Items.Add(dr[0]);
                        count++;
                    }

                    dr.Close();
                }
            }
        }



        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (searchradio1.Checked == false && searchradio2.Checked == false)
            {
                MessageBox.Show("Select Employee ID category or First Name category");
            }
            else
            {

                if (txtYear.Text != "" && cmbMonth.Text == "")
                {
                    dataGrid1.DataSource = null;
                    string sql = "SELECT * FROM AttendanceDetails WHERE " + search + "=@loginname  And CurrentYear=@curyear";
                    SqlCommand SqlCommand1 = con.CreateCommand();
                    SqlCommand1.CommandText = sql;
                    int res;
                    SqlCommand1.Parameters.Add("@loginname", SqlDbType.VarChar, 10);

                    SqlCommand1.Parameters.Add("@curyear", SqlDbType.VarChar, 30);
                    SqlCommand1.Parameters[0].Value = cmbSearch.SelectedItem;

                    SqlCommand1.Parameters[1].Value = txtYear.Text;
                    da = new SqlDataAdapter();
                    da.SelectCommand = SqlCommand1;
                    myDataSet = new System.Data.DataSet();
                    res = da.Fill(myDataSet, "AttendanceeDetails");

                    if (res >= 1)
                    {
                        dataGrid1.DataSource = myDataSet;
                        dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No record found");
                    }

                }
                if (cmbMonth.Text != "" && txtYear.Text == "")
                {
                    dataGrid1.DataSource = null;
                    string sql = "SELECT * FROM AttendanceDetails WHERE " + search + "=@loginname And CurrentMonth= @curmonth";
                    SqlCommand SqlCommand1 = con.CreateCommand();
                    SqlCommand1.CommandText = sql;
                    int res;
                    SqlCommand1.Parameters.Add("@loginname", SqlDbType.VarChar, 10);
                    SqlCommand1.Parameters.Add("@curmonth", SqlDbType.VarChar, 30);

                    SqlCommand1.Parameters[0].Value = cmbSearch.SelectedItem;
                    SqlCommand1.Parameters[1].Value = cmbMonth.SelectedItem;

                    da = new SqlDataAdapter();
                    da.SelectCommand = SqlCommand1;
                    myDataSet = new System.Data.DataSet();
                    res = da.Fill(myDataSet, "AttendanceeDetails");

                    if (res >= 1)
                    {
                        dataGrid1.DataSource = myDataSet;
                        dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No record found");
                    }

                }
                if (txtYear.Text != "" && cmbMonth.Text != "")
                {
                    dataGrid1.DataSource = null;
                    string sql = "SELECT * FROM AttendanceDetails WHERE " + search + "=@loginname And CurrentMonth= @curmonth And CurrentYear=@curyear";
                    SqlCommand SqlCommand1 = con.CreateCommand();
                    SqlCommand1.CommandText = sql;
                    int res;
                    SqlCommand1.Parameters.Add("@loginname", SqlDbType.VarChar, 10);
                    SqlCommand1.Parameters.Add("@curmonth", SqlDbType.VarChar, 30);
                    SqlCommand1.Parameters.Add("@curyear", SqlDbType.VarChar, 30);
                    SqlCommand1.Parameters[0].Value = cmbSearch.SelectedItem;
                    SqlCommand1.Parameters[1].Value = cmbMonth.SelectedItem;
                    SqlCommand1.Parameters[2].Value = txtYear.Text;
                    da = new SqlDataAdapter();
                    da.SelectCommand = SqlCommand1;
                    myDataSet = new System.Data.DataSet();
                    res = da.Fill(myDataSet, "AttendanceeDetails");

                    if (res >= 1)
                    {
                        dataGrid1.DataSource = myDataSet;
                        dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No record found");
                    }

                }


            }

        }

        private void searchradio2_CheckedChanged(object sender, EventArgs e)
        {
            if (searchradio2.Checked == true)
            {
                if (txtYear.Text == "" && cmbMonth.Text == "")
                {
                    MessageBox.Show("Enter a year or select a month or both");
                }
                else
                {
                    cmbSearch.Text = "";
                    dataGrid1.DataSource = null;
                    search = "EmpID";
                    cmbSearch.Items.Clear();

                    int count = 0;

                    string sql = "SELECT EmpID FROM EmployeeSalaryAgreement WHERE EmpID NOT IN('HR001')";
                    SqlCommand SqlCommand1 = new SqlCommand(sql, con);
                    SqlDataReader dr = SqlCommand1.ExecuteReader();
                    while (dr.Read())
                    {
                        cmbSearch.Items.Add(dr[0]);
                        count++;
                    }

                    dr.Close();
                }
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {


            dataGrid1.DataSource = null;
            da = new SqlDataAdapter("Select * from AttendanceDetails", con);
            myDataSet = new DataSet();
            da.Fill(myDataSet);
            dataGrid1.DataSource = myDataSet;
            dataGrid1.DataMember = myDataSet.Tables[0].ToString();
            searchradio1.Checked = false;
            searchradio2.Checked = false;
            txtYear.Text = "";
            cmbMonth.SelectedIndex = -1;
            cmbSearch.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {


            cmbSearch.Text = "";
            searchradio1.Checked = false;
            searchradio2.Checked = false;
            if (txtYear.Text != "")
            {
                dataGrid1.DataSource = null;
                string sql = "SELECT * FROM AttendanceDetails WHERE CurrentYear=@curyear";
                SqlCommand SqlCommand1 = con.CreateCommand();
                SqlCommand1.CommandText = sql;
                int res;


                SqlCommand1.Parameters.Add("@curyear", SqlDbType.VarChar, 30);


                SqlCommand1.Parameters[0].Value = txtYear.Text;
                da = new SqlDataAdapter();
                da.SelectCommand = SqlCommand1;
                myDataSet = new System.Data.DataSet();
                res = da.Fill(myDataSet, "AttendanceeDetails");

                if (res >= 1)
                {
                    dataGrid1.DataSource = myDataSet;
                    dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                }

            }
            if (txtYear.Text != "" && cmbMonth.Text != "")
            {
                dataGrid1.DataSource = null;
                string sql = "SELECT * FROM AttendanceDetails WHERE CurrentMonth= @curmonth And CurrentYear=@curyear";
                SqlCommand SqlCommand1 = con.CreateCommand();
                SqlCommand1.CommandText = sql;
                int res;

                SqlCommand1.Parameters.Add("@curmonth", SqlDbType.VarChar, 30);
                SqlCommand1.Parameters.Add("@curyear", SqlDbType.VarChar, 30);

                SqlCommand1.Parameters[0].Value = cmbMonth.SelectedItem;
                SqlCommand1.Parameters[1].Value = txtYear.Text;
                da = new SqlDataAdapter();
                da.SelectCommand = SqlCommand1;
                myDataSet = new System.Data.DataSet();
                res = da.Fill(myDataSet, "AttendanceeDetails");

                if (res >= 1)
                {
                    dataGrid1.DataSource = myDataSet;
                    dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                }

            }
            if (txtYear.Text == "")
            {
                dataGrid1.DataSource = null;

            }





        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {


            cmbSearch.Text = "";
            searchradio1.Checked = false;
            searchradio2.Checked = false;
            if (cmbMonth.Text != "")
            {
                dataGrid1.DataSource = null;
                string sql = "SELECT * FROM AttendanceDetails WHERE CurrentMonth= @curmonth";
                SqlCommand SqlCommand1 = con.CreateCommand();
                SqlCommand1.CommandText = sql;
                int res;

                SqlCommand1.Parameters.Add("@curmonth", SqlDbType.VarChar, 30);


                SqlCommand1.Parameters[0].Value = cmbMonth.SelectedItem;

                da = new SqlDataAdapter();
                da.SelectCommand = SqlCommand1;
                myDataSet = new System.Data.DataSet();
                res = da.Fill(myDataSet, "AttendanceeDetails");

                if (res >= 1)
                {
                    dataGrid1.DataSource = myDataSet;
                    dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                }

            }
            if (txtYear.Text != "" && cmbMonth.Text != "")
            {
                dataGrid1.DataSource = null;
                string sql = "SELECT * FROM AttendanceDetails WHERE CurrentMonth= @curmonth And CurrentYear=@curyear";
                SqlCommand SqlCommand1 = con.CreateCommand();
                SqlCommand1.CommandText = sql;
                int res;

                SqlCommand1.Parameters.Add("@curmonth", SqlDbType.VarChar, 30);
                SqlCommand1.Parameters.Add("@curyear", SqlDbType.VarChar, 30);

                SqlCommand1.Parameters[0].Value = cmbMonth.SelectedItem;
                SqlCommand1.Parameters[1].Value = txtYear.Text;
                da = new SqlDataAdapter();
                da.SelectCommand = SqlCommand1;
                myDataSet = new System.Data.DataSet();
                res = da.Fill(myDataSet, "AttendanceeDetails");

                if (res >= 1)
                {
                    dataGrid1.DataSource = myDataSet;
                    dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                }

            }
            if (cmbMonth.Text == "")
            {
                dataGrid1.DataSource = null;

            }


        }
    }
}
