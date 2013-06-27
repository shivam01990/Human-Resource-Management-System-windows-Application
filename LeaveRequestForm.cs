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
    public partial class LeaveRequestForm : Form
    {
        SqlTransaction objTran = null;
        SqlConnection con = null;
        SqlCommand SqlCommand1;
        SqlDataAdapter da;
        DataSet myDataSet;
        int count;
        bool valid1, valid2;
        int fromdate, todate;
        public LeaveRequestForm()
        {
            InitializeComponent();
            con = new SqlConnection(GlobalClass.conn);
            con.Open();
            string sql = "SELECT EmpID FROM EmployeeSalaryAgreement WHERE EmpID NOT IN('HR001')";
            SqlCommand1 = new SqlCommand(sql, con);
            SqlDataReader dr = SqlCommand1.ExecuteReader();
            while (dr.Read())
            {
                cmbEmpID.Items.Add(dr[0]);
                count++;
            }

            dr.Close();
        }
        private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbEmpID.SelectedIndex != -1)
                {
                    string sql = "SELECT * FROM EmployeeDetails WHERE EmpID=@empid";
                    SqlCommand SqlCommand1 = con.CreateCommand();
                    SqlCommand1.CommandText = sql;
                    int res;
                    SqlCommand1.Parameters.Add("@empid", SqlDbType.VarChar, 10);
                    SqlCommand1.Parameters[0].Value = cmbEmpID.SelectedItem;
                    da = new SqlDataAdapter();
                    da.SelectCommand = SqlCommand1;
                    myDataSet = new System.Data.DataSet();
                    res = da.Fill(myDataSet, "EmployeeDetails");

                    if (res >= 1)
                    {


                        txtFName.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["FName"].ToString();

                        txtEmpID.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["EmpID"].ToString();

                        txtDept.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Department"].ToString();


                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Record not found");
            }

        }





        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {

            ViewLeaveRequest vlr = new ViewLeaveRequest();
            vlr.ShowDialog();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpID.Text == "")
                {
                    MessageBox.Show("Please select an Employee ID first");
                    txtEmpID.Focus();
                    return;
                }
                if (txtMonth.Text == "")
                {
                    MessageBox.Show("Please select a name of the month");
                    txtMonth.Focus();
                    return;
                }
                if (txtYear.Text == "")
                {
                    MessageBox.Show("Please enter an year");
                    txtYear.Focus();
                    return;
                }

                if (txtNODays.Text == "")
                {
                    MessageBox.Show("Please enter no. of leaves");
                    txtNODays.Focus();
                    return;

                }
                if (Convert.ToDateTime(txtFrom.Text) > Convert.ToDateTime(txtTo.Text))
                {
                    MessageBox.Show("Please check the dates for which leaves to be taken.");
                    return;
                }

                else
                {

                    if (txtFrom.Text != "" && txtTo.Text != "" && txtNODays.Text != "")
                    {
                        txtFrom.Format = DateTimePickerFormat.Custom;

                        txtFrom.CustomFormat = "";
                        txtFrom.CustomFormat = "dd";
                        fromdate = Convert.ToInt32(txtFrom.Text);


                        txtTo.Format = DateTimePickerFormat.Custom;
                        txtTo.CustomFormat = "";
                        txtTo.CustomFormat = "dd";
                        todate = Convert.ToInt32(txtTo.Text);
                        txtFrom.Format = DateTimePickerFormat.Short;
                        txtTo.Format = DateTimePickerFormat.Short;


                        int diff = (todate - fromdate) + 1;
                        if (Convert.ToInt32(txtNODays.Text) != diff)
                        {
                            MessageBox.Show("Please enter correct no. of leaves");
                            txtNODays.Text = "";
                            return;
                        }

                    }

                    if (txtEmpID.Text != "HR001")
                    {

                        con = new System.Data.SqlClient.SqlConnection(GlobalClass.conn);
                        con.Open();
                        string sql1 = "SELECT * FROM leaveDetails WHERE EmpID=@empid And FromDate=@fdate";
                        SqlCommand SqlCommand1 = con.CreateCommand();
                        SqlCommand1.CommandText = sql1;
                        int res1;
                        SqlCommand1.Parameters.Add("@empid", SqlDbType.VarChar, 10);
                        SqlCommand1.Parameters.Add("@fdate", SqlDbType.VarChar, 30);


                        SqlCommand1.Parameters[0].Value = txtEmpID.Text;
                        SqlCommand1.Parameters[1].Value = txtFrom.Text;


                        SqlDataAdapter da1 = new SqlDataAdapter();
                        da1.SelectCommand = SqlCommand1;
                        DataSet myDataSet1 = new DataSet();
                        res1 = da1.Fill(myDataSet1, "LeaveDetails");
                        if (res1 >= 1)
                        {
                            valid1 = true;


                        }
                        else
                        {
                            valid1 = false;
                        }

                        string sql2 = "SELECT * FROM leaveDetails WHERE EmpID=@empid And ToDate=@tdate";
                        SqlCommand SqlCommand2 = con.CreateCommand();
                        SqlCommand2.CommandText = sql2;
                        int res2;
                        SqlCommand2.Parameters.Add("@empid", SqlDbType.VarChar, 10);

                        SqlCommand2.Parameters.Add("@tdate", SqlDbType.VarChar, 30);

                        SqlCommand2.Parameters[0].Value = txtEmpID.Text;

                        SqlCommand2.Parameters[1].Value = txtTo.Text;

                        SqlDataAdapter da2 = new SqlDataAdapter();
                        da2.SelectCommand = SqlCommand2;
                        DataSet myDataSet2 = new DataSet();
                        res2 = da2.Fill(myDataSet2, "LeaveDetails");
                        if (res2 >= 1)
                        {


                            valid2 = true;


                        }
                        else
                        {
                            valid2 = false;
                        }


                        if (valid1 == true && valid2 == true)
                        {
                            MessageBox.Show("Leave details of " + txtFName.Text + " is already added");
                            refreshfields();
                            return;
                        }
                        if (valid1 == true && valid2 == false)
                        {
                            SqlCommand objUpdate = con.CreateCommand();


                            objUpdate.CommandText = "update LeaveDetails set ToDate='" + txtTo.Text + "',NoOfDays=" + Convert.ToInt32(txtNODays.Text) + ",Reason='" + txtReason.Text + "' WHERE EmpID='" + cmbEmpID.SelectedItem + "' And FromDate='" + txtFrom.Text + "'";
                            objUpdate.Connection = con;
                            objUpdate.Transaction = objTran;
                            int result = objUpdate.ExecuteNonQuery();
                            if (result >= 1)
                            {
                                MessageBox.Show("Leave details of " + txtFName.Text + " is updated");
                                refreshfields();
                                return;
                            }

                        }
                        if (valid2 == true && valid1 == false)
                        {
                            SqlCommand objUpdate = con.CreateCommand();
                            objUpdate.CommandText = "update LeaveDetails set FromDate='" + txtFrom.Text + "',NoOfDays=" + Convert.ToInt32(txtNODays.Text) + ",Reason='" + txtReason.Text + "' WHERE EmpID='" + cmbEmpID.SelectedItem + "' And ToDate='" + txtTo.Text + "'";

                            objUpdate.Connection = con;
                            objUpdate.Transaction = objTran;
                            int result = objUpdate.ExecuteNonQuery();
                            if (result >= 1)
                            {
                                MessageBox.Show("Leave details of " + txtFName.Text + " is updated");
                                refreshfields();
                                return;
                            }
                        }
                        if (valid1 == false && valid2 == false)
                        {
                            SqlDataAdapter adp = new SqlDataAdapter("select * from LeaveDetails", con);
                            DataSet ds = new DataSet();
                            adp.Fill(ds, "LeaveDetails");
                            int var = ds.Tables["LeaveDetails"].Rows.Count;

                            DataTable table = null;
                            table = ds.Tables["LeaveDetails"];

                            DataRow newRow = null;

                            newRow = table.NewRow();

                            newRow["EmpID"] = txtEmpID.Text;
                            newRow["FName"] = txtFName.Text;
                            newRow["Department"] = txtDept.Text;

                            newRow["CurrentMonth"] = txtMonth.Text;
                            newRow["CurrentYear"] = txtYear.Text;
                            newRow["FromDate"] = txtFrom.Text;
                            newRow["ToDate"] = txtTo.Text;
                            newRow["NoOfDays"] = Convert.ToInt32(txtNODays.Text);
                            newRow["Reason"] = txtReason.Text;
                            table.Rows.Add(newRow);
                            SqlCommandBuilder commandBuilder = null;
                            commandBuilder = new SqlCommandBuilder(adp);
                            adp.InsertCommand = commandBuilder.GetInsertCommand();
                            adp.Update(ds, "LeaveDetails");
                            MessageBox.Show("Leave Request of " + txtFName.Text + " is added.", "Leave Request Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshfields();
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("HR001 is Admin record, its leave request is rejected.", "Leave Request Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Provided data not in a correct format");
            }

        }




        void refreshfields()
        {
            cmbEmpID.SelectedIndex = -1;
            txtEmpID.Text = "";
            txtFName.Text = "";
            txtDept.Text = "";

            txtMonth.SelectedIndex = -1;
            txtYear.Text = "";
            txtFrom.Text = System.DateTime.Today.ToString();
            txtTo.Text = System.DateTime.Today.ToString(); ;
            txtNODays.Text = "0";
            txtReason.Text = "";
            cmbEmpID.Items.Clear();
            string sql = "SELECT EmpID FROM EmployeeSalaryAgreement WHERE EmpID NOT IN('HR001')";
            SqlCommand SqlCommand5 = new SqlCommand(sql, con);
            SqlDataReader dr = SqlCommand5.ExecuteReader();
            while (dr.Read())
            {
                cmbEmpID.Items.Add(dr[0]);
                count++;
            }

            dr.Close();
        }
    }
}
