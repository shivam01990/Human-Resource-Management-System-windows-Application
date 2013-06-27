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
    public partial class CalcSalary : Form
    {
        SqlConnection con;
        SqlTransaction objTran;
        SqlCommand SqlCommand1;
        SqlDataAdapter da;
        int count;
        DataSet myDataSet;
        int fixedsalary, noofdays, deductionperday, leavededuction, overtimehours, paymentperhour, overtimepayment, total;
       
        public CalcSalary()
        {
            InitializeComponent();
            leavededuction = 0;
            overtimepayment = 0;
            total = 0;
            con = new SqlConnection(GlobalClass.conn);
            con.Open();

            txtOvertimeHours.Text = "0";
            txtNoOfLeaves.Text = "0";
            string sql = "SELECT EmpID FROM EmployeeSalaryAgreement WHERE EmpID NOT IN('HR001')";
            SqlCommand1 = new SqlCommand(sql, con);
            SqlDataReader dr = SqlCommand1.ExecuteReader();
            while (dr.Read())
            {
                cbEmpID.Items.Add(dr[0]);
                count++;
            }

            dr.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbEmpID.Text == "")
            {
                MessageBox.Show("Please select an Employee ID first");

                return;
            }
            if (txtYear.Text == "")
            {
                MessageBox.Show("Please enter an Year");
                txtYear.Focus();
                return;
            }
            if (cbMonth.Text == "")
            {
                MessageBox.Show("Please select a Month");

                return;
            }
            else
            {
                if (cbEmpID.Text != "HR001")
                {
                    try
                    {

                        string sql = "SELECT * FROM SalaryDetails WHERE EmpID=@empid And YearOfSalary=@yr And MonthOfSalary=@month";
                        SqlCommand SqlCommand1 = con.CreateCommand();
                        SqlCommand1.CommandText = sql;
                        int res;
                        SqlCommand1.Parameters.Add("@empid", SqlDbType.VarChar, 10);
                        SqlCommand1.Parameters.Add("@yr", SqlDbType.VarChar, 30);
                        SqlCommand1.Parameters.Add("@month", SqlDbType.VarChar, 30);
                        SqlCommand1.Parameters[0].Value = cbEmpID.Text;
                        SqlCommand1.Parameters[1].Value = txtYear.Text;
                        SqlCommand1.Parameters[2].Value = cbMonth.Text;

                        da = new SqlDataAdapter();
                        da.SelectCommand = SqlCommand1;
                        myDataSet = new System.Data.DataSet();
                        res = da.Fill(myDataSet, "SalaryDetails");
                        if (res >= 1)
                        {
                            SqlCommand objUpdate = con.CreateCommand();
                            objUpdate.CommandText = "update SalaryDetails set EmpID ='" + cbEmpID.Text + "',FName ='" + txtFName.Text + "',FixedSalary ='" + Convert.ToInt32(txtFixedSalary.Text) + "',Department = '" + txtDepartment.Text + "',Designation = '" + txtDesignation.Text + "',BankName = '" + txtBankName.Text + "',AccountNo = '" + txtAccNo.Text + "',MonthOfSalary = '" + cbMonth.Text + "',YearOfSalary = '" + txtYear.Text + "',NoOfLeaves = '" + Convert.ToInt32(txtNoOfLeaves.Text) + "',TotalDeduction = '" + Convert.ToInt32(txtLeaveDeduction.Text) + "',OvertimeHours = '" + Convert.ToInt32(txtOvertimeHours.Text) + "',OvertimePayments = '" + Convert.ToInt32(txtOvertimePayments.Text) + "',TotalSalary = '" + Convert.ToInt32(txtTotalSalary.Text) + "',Remarks = '" + txtRemarks.Text + "' WHERE EmpID='" + cbEmpID.SelectedItem + "'";
                            objUpdate.Connection = con;
                            objUpdate.Transaction = objTran;
                            int res2 = objUpdate.ExecuteNonQuery();
                            if (res2 >= 1)
                            {
                                MessageBox.Show("Salary details is updated for " + txtFName.Text + "\n for the Month: " + cbMonth.Text, "Salary Details Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cbEmpID.SelectedIndex = -1;
                                txtFName.Text = "";
                                txtFixedSalary.Text = "";
                                txtDepartment.Text = "";
                                txtDesignation.Text = "";
                                txtBankName.Text = "";
                                txtAccNo.Text = "";

                                cbMonth.SelectedIndex = -1;
                                txtYear.Text = "";
                                txtNoOfLeaves.Text = "0";

                                txtLeaveDeduction.Text = "0";

                                txtOvertimeHours.Text = "0";

                                txtOvertimePayments.Text = "0";
                                txtTotalSalary.Text = "0";
                                txtRemarks.Text = "";
                            }
                        }



                        else
                        {

                            //******************
                            SqlDataAdapter adp = new SqlDataAdapter("select * from SalaryDetails", con);
                            DataSet ds = new DataSet();
                            adp.Fill(ds, "SalaryDetails");
                            int var = ds.Tables["SalaryDetails"].Rows.Count;

                            DataTable table = null;
                            table = ds.Tables["SalaryDetails"];

                            DataRow newRow = null;

                            newRow = table.NewRow();

                            newRow["EmpID"] = cbEmpID.Text;
                            newRow["FName"] = txtFName.Text;
                            newRow["FixedSalary"] = Convert.ToInt32(txtFixedSalary.Text);
                            newRow["Department"] = txtDepartment.Text;
                            newRow["Designation"] = txtDesignation.Text;
                            newRow["BankName"] = txtBankName.Text;
                            newRow["AccountNo"] = txtAccNo.Text;

                            newRow["MonthOfSalary"] = cbMonth.Text;
                            newRow["YearOfSalary"] = txtYear.Text;
                            newRow["NoOfLeaves"] = Convert.ToInt32(txtNoOfLeaves.Text);

                            newRow["TotalDeduction"] = Convert.ToInt32(txtLeaveDeduction.Text);

                            newRow["OvertimeHours"] = Convert.ToInt32(txtOvertimeHours.Text);

                            newRow["OvertimePayments"] = Convert.ToInt32(txtOvertimePayments.Text);
                            newRow["TotalSalary"] = Convert.ToInt32(txtTotalSalary.Text);
                            newRow["Remarks"] = txtRemarks.Text;



                            table.Rows.Add(newRow);
                            SqlCommandBuilder commandBuilder = null;
                            commandBuilder = new SqlCommandBuilder(adp);
                            adp.InsertCommand = commandBuilder.GetInsertCommand();
                            adp.Update(ds, "SalaryDetails");
                            MessageBox.Show("Salary details added of " + txtFName.Text + "\n for the Month: " + cbMonth.Text, "Salary Details Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbEmpID.SelectedIndex = -1;
                            txtFName.Text = "";
                            txtFixedSalary.Text = "";
                            txtDepartment.Text = "";
                            txtDesignation.Text = "";
                            txtBankName.Text = "";
                            txtAccNo.Text = "";

                            cbMonth.SelectedIndex = -1;
                            txtYear.Text = "";
                            txtNoOfLeaves.Text = "";

                            txtLeaveDeduction.Text = "";

                            txtOvertimeHours.Text = "";

                            txtOvertimePayments.Text = "";
                            txtTotalSalary.Text = "";
                            txtRemarks.Text = "";
                        }

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("HR001 is Admin record, its salary cannot be calculated.", "Salary Calculation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmpID.SelectedIndex != -1)
            {
                try
                {


                    string sql = "SELECT * FROM EmployeeSalaryAgreement where EmpID=@empid";
                    SqlCommand SqlCommand1 = con.CreateCommand();
                    SqlCommand1.CommandText = sql;
                    int res;
                    SqlCommand1.Parameters.Add("@empid", SqlDbType.VarChar, 10);
                    SqlCommand1.Parameters[0].Value = cbEmpID.SelectedItem;
                    da = new SqlDataAdapter();
                    da.SelectCommand = SqlCommand1;
                    myDataSet = new System.Data.DataSet();
                    res = da.Fill(myDataSet, "EmployeeSalaryAgreement");

                    if (res >= 1)
                    {


                        txtFName.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["FName"].ToString();
                        txtFixedSalary.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["MonthlySalary"].ToString();
                        txtDepartment.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["Department"].ToString();
                        txtDesignation.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["Designation"].ToString();
                        txtBankName.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["BankName"].ToString();
                        txtAccNo.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["AccountNo"].ToString();
                        deductionperday = Convert.ToInt32(myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["SalaryPerDay"].ToString());
                        paymentperhour = Convert.ToInt32(myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["OvertimePerHour"].ToString());
                        txtYear.Text = "";
                        cbMonth.SelectedIndex = -1;
                    }





                    fixedsalary = Convert.ToInt32(txtFixedSalary.Text);

                    total = fixedsalary + overtimepayment - leavededuction;
                    txtTotalSalary.Text = total.ToString();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Please fill up Employee Salary Agreement form");
                }
            }

        }

        private void txtNoOfLeaves_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOfLeaves.Text == "")
            {
                noofdays = 0;
            }
            else
            {
                noofdays = Convert.ToInt32(txtNoOfLeaves.Text);
            }
            leavededuction = noofdays * deductionperday;
            txtLeaveDeduction.Text = leavededuction.ToString();

            total = fixedsalary + overtimepayment - leavededuction;
            txtTotalSalary.Text = total.ToString();

        }



        private void txtOvertimeHours_TextChanged(object sender, EventArgs e)
        {
            if (txtOvertimeHours.Text == "")
            {
                overtimehours = 0;
            }
            else
            {
                overtimehours = Convert.ToInt32(txtOvertimeHours.Text);
            }
            overtimepayment = overtimehours * paymentperhour;
            txtOvertimePayments.Text = overtimepayment.ToString();
            total = fixedsalary + overtimepayment - leavededuction;
            txtTotalSalary.Text = total.ToString();
        }



        private void txtFixedSalary_TextChanged(object sender, EventArgs e)
        {
            total = fixedsalary + overtimepayment - leavededuction;
            txtTotalSalary.Text = total.ToString();
        }


        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMonth.SelectedIndex != -1)
            {
                try
                {

                    string yr = txtYear.Text;
                    if (yr == "")
                    {
                        throw new Exception();
                    }
                    if (yr != "")
                    {

                        string sql2 = "SELECT NoOfDays from LeaveDetails WHERE EmpID=@empid And CurrentMonth=@mon And CurrentYear=@yr";
                        SqlCommand SqlCommand2 = con.CreateCommand();
                        SqlCommand2.CommandText = sql2;
                        int res2;
                        SqlCommand2.Parameters.Add("@empid", SqlDbType.VarChar, 10);
                        SqlCommand2.Parameters.Add("@mon", SqlDbType.VarChar, 30);
                        SqlCommand2.Parameters.Add("@yr", SqlDbType.VarChar, 30);
                        SqlCommand2.Parameters[0].Value = cbEmpID.Text;
                        SqlCommand2.Parameters[1].Value = cbMonth.Text;
                        SqlCommand2.Parameters[2].Value = txtYear.Text;
                        SqlDataAdapter da2 = new SqlDataAdapter();
                        da2.SelectCommand = SqlCommand2;
                        DataSet myDataSet2 = new System.Data.DataSet();
                        res2 = da2.Fill(myDataSet2, "LeaveDetails");

                        int p = 0;
                        if (res2 >= 1)
                        {
                            for (int j = 0; j < res2; j++)
                            {

                                p += Convert.ToInt32(myDataSet2.Tables["LeaveDetails"].Rows[j]["NoOfDays"].ToString());

                            }
                            txtNoOfLeaves.Text = p.ToString();
                        }





                        string sql3 = "Select OvertimeHours from AttendanceDetails WHERE EmpID=@empid And CurrentMonth=@mon And CurrentYear=@yr";
                        SqlCommand SqlCommand3 = con.CreateCommand();
                        SqlCommand3.CommandText = sql3;
                        int res3;

                        SqlCommand3.Parameters.Add("@empid", SqlDbType.VarChar, 10);
                        SqlCommand3.Parameters.Add("@mon", SqlDbType.VarChar, 30);
                        SqlCommand3.Parameters.Add("@yr", SqlDbType.VarChar, 30);
                        SqlCommand3.Parameters[0].Value = cbEmpID.Text;
                        SqlCommand3.Parameters[1].Value = cbMonth.Text;
                        SqlCommand3.Parameters[2].Value = txtYear.Text;
                        SqlDataAdapter da3 = new SqlDataAdapter();
                        da3.SelectCommand = SqlCommand3;
                        DataSet myDataSet3 = new System.Data.DataSet();
                        res3 = da3.Fill(myDataSet3, "AttendanceDetails");
                        int i = 0;
                        if (res3 >= 1)
                        {
                            for (int j = 0; j < res3; j++)
                            {

                                i += Convert.ToInt32(myDataSet3.Tables["AttendanceDetails"].Rows[j]["OvertimeHours"].ToString());

                            }
                            txtOvertimeHours.Text = i.ToString();
                        }
                        noofdays = p;
                        overtimehours = i;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter an year");

                    txtYear.Focus();

                }
            }

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

            if (txtYear.Text != "")
            {
                cbMonth.SelectedIndex = -1;
                try
                {
                    string str = txtYear.Text.ToString();
                    foreach (char c in str)
                    {
                        if (Char.IsLetter(c))
                        {
                            MessageBox.Show("Please Enter only Number");
                            txtYear.Text = "";
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Year is not in correct format");
                    txtYear.Text = "";
                    return;
                }

            }
        }
    }
}
