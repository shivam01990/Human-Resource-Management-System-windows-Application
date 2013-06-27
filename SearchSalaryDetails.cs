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
    public partial class SearchSalaryDetails : Form
    {
        string search;
              
        SqlDataAdapter da;
        DataSet myDataSet;
        public SearchSalaryDetails()
        {
            InitializeComponent();
        }
        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtYear.Text == "" && cmbMonth.Text == "")
            {
                MessageBox.Show("Enter a year or select a month or both");
            }
            else if (rbEmpName.Checked == false && rbEmpID.Checked == false)
            {
                MessageBox.Show("Select Employee ID category or Employee Name category");
            }
            else
            {
                if (txtYear.Text != "" && cmbMonth.Text == "")
                {
                    dataGrid1.DataSource = null;
                    SqlConnection con = new SqlConnection(GlobalClass.conn);
                    con.Open();
                    string sql = "SELECT * FROM SalaryDetails WHERE " + search + "=@loginname And YearOfSalary= @curyear";
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
                    res = da.Fill(myDataSet, "SalaryDetails");

                    if (res >= 1)
                    {
                        dataGrid1.DataSource = myDataSet;
                        dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                    }
                    else
                    {
                        dataGrid1.DataSource = myDataSet;
                        dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                        MessageBox.Show("No record found");
                    }
                }
                if (txtYear.Text == "" && cmbMonth.Text != "")
                {
                    dataGrid1.DataSource = null;
                    SqlConnection con = new SqlConnection(GlobalClass.conn);
                    con.Open();
                    string sql = "SELECT * FROM SalaryDetails WHERE " + search + "=@loginname And MonthOfSalary=@curmonth";
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
                    res = da.Fill(myDataSet, "SalaryDetails");

                    if (res >= 1)
                    {
                        dataGrid1.DataSource = myDataSet;
                        dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                    }
                    else
                    {
                        dataGrid1.DataSource = myDataSet;
                        dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                        MessageBox.Show("No record found");
                    }
                }
                if (txtYear.Text != "" && cmbMonth.Text != "")
                {
                    dataGrid1.DataSource = null;
                    SqlConnection con = new SqlConnection(GlobalClass.conn);
                    con.Open();
                    string sql = "SELECT * FROM SalaryDetails WHERE " + search + "=@loginname And YearOfSalary= @curyear And MonthOfSalary=@curmonth";
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
                    res = da.Fill(myDataSet, "SalaryDetails");

                    if (res >= 1)
                    {
                        dataGrid1.DataSource = myDataSet;
                        dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                    }
                    else
                    {
                        dataGrid1.DataSource = myDataSet;
                        dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                        MessageBox.Show("No record found");
                    }
                }
            }
        }

        private void rbEmpName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpName.Checked == true)
            {
                if (txtYear.Text == "" && cmbMonth.Text == "")
                {
                    MessageBox.Show("Enter a year or select a month or both");
                }
                else
                {
                    cmbSearch.Text = "";
                    dataGrid1.DataSource = null;
                    cmbSearch.Items.Clear();

                    SqlConnection con = new SqlConnection(GlobalClass.conn);
                    con.Open();
                    search = "FName";
                    int count = 0;
                    //string sql = "SELECT FName FROM EmployeeDetails WHERE EmpID NOT IN('HR001')";
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

        private void rbEmpID_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpID.Checked == true)
            {
                if (txtYear.Text == "" && cmbMonth.Text == "")
                {
                    MessageBox.Show("Enter a year or select a month or both");
                }
                else
                {
                    cmbSearch.Text = "";
                    dataGrid1.DataSource = null;
                    cmbSearch.Items.Clear();

                    search = "EmpID";
                    SqlConnection con = new SqlConnection(GlobalClass.conn);
                    con.Open();
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

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbSearch.Text = "";
            rbEmpName.Checked = false;
            rbEmpID.Checked = false;
            if (cmbMonth.Text != "")
            {
                dataGrid1.DataSource = null;
                SqlConnection con = new SqlConnection(GlobalClass.conn);
                con.Open();
                string sql = "SELECT * FROM SalaryDetails WHERE MonthOfSalary=@curmonth";
                SqlCommand SqlCommand1 = con.CreateCommand();
                SqlCommand1.CommandText = sql;
                int res;

                SqlCommand1.Parameters.Add("@curmonth", SqlDbType.VarChar, 30);
                SqlCommand1.Parameters[0].Value = cmbMonth.SelectedItem;

                da = new SqlDataAdapter();
                da.SelectCommand = SqlCommand1;
                myDataSet = new System.Data.DataSet();
                res = da.Fill(myDataSet, "SalaryDetails");

                if (res >= 1)
                {
                    dataGrid1.DataSource = myDataSet;
                    dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                }
                else
                {
                    dataGrid1.DataSource = myDataSet;
                    dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                }
            }

            if (txtYear.Text != "" && cmbMonth.Text != "")
            {
                dataGrid1.DataSource = null;
                SqlConnection con = new SqlConnection(GlobalClass.conn);
                con.Open();
                string sql = "SELECT * FROM SalaryDetails WHERE YearOfSalary= @curyear And MonthOfSalary=@curmonth";
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
                res = da.Fill(myDataSet, "SalaryDetails");

                if (res >= 1)
                {
                    dataGrid1.DataSource = myDataSet;
                    dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                }
                else
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

        private void btnSlipOrReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult dr = new DialogResult();
            SalarySlip ss = new SalarySlip();
            dr = ss.ShowDialog();
        }

        private void btnAllEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult dr = new DialogResult();
            SalaryReportofEmployee esa = new SalaryReportofEmployee();
            dr = esa.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            cmbSearch.Text = "";
            rbEmpName.Checked = false;
            rbEmpID.Checked = false;
            if (txtYear.Text != "")
            {
                dataGrid1.DataSource = null;
                SqlConnection con = new SqlConnection(GlobalClass.conn);
                con.Open();
                string sql = "SELECT * FROM SalaryDetails WHERE YearOfSalary= @curyear";
                SqlCommand SqlCommand1 = con.CreateCommand();
                SqlCommand1.CommandText = sql;
                int res;


                SqlCommand1.Parameters.Add("@curyear", SqlDbType.VarChar, 30);


                SqlCommand1.Parameters[0].Value = txtYear.Text;
                da = new SqlDataAdapter();
                da.SelectCommand = SqlCommand1;
                myDataSet = new System.Data.DataSet();
                res = da.Fill(myDataSet, "SalaryDetails");

                if (res >= 1)
                {
                    dataGrid1.DataSource = myDataSet;
                    dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                }
                else
                {
                    dataGrid1.DataSource = myDataSet;
                    dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                }
            }

            if (txtYear.Text != "" && cmbMonth.Text != "")
            {
                dataGrid1.DataSource = null;
                SqlConnection con = new SqlConnection(GlobalClass.conn);
                con.Open();
                string sql = "SELECT * FROM SalaryDetails WHERE YearOfSalary= @curyear And MonthOfSalary=@curmonth";
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
                res = da.Fill(myDataSet, "SalaryDetails");

                if (res >= 1)
                {
                    dataGrid1.DataSource = myDataSet;
                    dataGrid1.DataMember = myDataSet.Tables[0].ToString();
                }
                else
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
    }
}
