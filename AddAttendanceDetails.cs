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
    public partial class AddAttendanceDetails : Form
    {
        SqlConnection con;
        SqlTransaction objTran;

        SqlCommand SqlCommand1;
        SqlDataAdapter da;
        int count;

        DataSet myDataSet;
        public AddAttendanceDetails()
        {
            InitializeComponent();
            con = new SqlConnection(GlobalClass.conn);
            con.Open();

            txtOvertimeHours.Text = "0";

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
        private void cbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM EmployeeDetails WHERE EmpID=@empid";
                SqlCommand SqlCommand1 = con.CreateCommand();
                SqlCommand1.CommandText = sql;
                int res;
                SqlCommand1.Parameters.Add("@empid", SqlDbType.VarChar, 10);
                SqlCommand1.Parameters[0].Value = cbEmpID.SelectedItem;
                da = new SqlDataAdapter();
                da.SelectCommand = SqlCommand1;
                myDataSet = new System.Data.DataSet();
                res = da.Fill(myDataSet, "EmployeeDetails");

                if (res >= 1)
                {


                    txtFName.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["FName"].ToString();

                    txtEmpID.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["EmpID"].ToString();

                    txtDepartment.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Department"].ToString();
                    txtDesignation.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Designation"].ToString();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Record not found");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbEmpID.Text == "")
            {
                MessageBox.Show("Please select an Employee ID first");
                txtEmpID.Focus();
            }
            else if (txtTimeIn.Text == "")
            {
                MessageBox.Show("Please enter time in");
                txtTimeIn.Focus();
            }
            else if (txtTimeOut.Text == "")
            {
                MessageBox.Show("Please enter time out");
                txtTimeOut.Focus();
            }
            else if (txtOvertimeHours.Text == "")
            {
                MessageBox.Show("Please enter extra time in hours");
                txtOvertimeHours.Focus();
            }


            else
            {
                try
                {
                    if (txtTimeIn.Text != "" && txtTimeOut.Text != "")
                    {
                        int i = 0, j = 0;
                        bool validval1 = false, validval2 = false;
                        string str1 = txtTimeIn.Text.ToString();
                        string str2 = txtTimeOut.Text.ToString();
                        foreach (char c in str1)
                        {
                            i = i + 1;
                            if (i > 5)
                            {
                                MessageBox.Show("Time is not in proper format");
                                txtTimeIn.Text = "";
                                txtTimeOut.Text = "";
                                return;
                            }

                            if (i == 3 && c == ':')
                            {
                                validval1 = true;

                            }
                        }
                        foreach (char c in str2)
                        {
                            j = j + 1;
                            if (j > 5)
                            {
                                MessageBox.Show("Time is not in proper format");
                                txtTimeIn.Text = "";
                                txtTimeOut.Text = "";
                                return;
                            }
                            if (j == 3 && c == ':')
                            {
                                validval2 = true;

                            }
                        }
                        if (validval1 == false || validval2 == false)
                        {
                            MessageBox.Show("Time In or Time Out is not in proper format");
                            txtTimeIn.Text = "";
                            txtTimeOut.Text = "";
                            return;
                        }
                        int num1 = Convert.ToInt32(txtTimeIn.Text.ToString().Substring(0, 2));
                        int num2 = Convert.ToInt32(txtTimeIn.Text.ToString().Substring(3, 2));
                        int num3 = Convert.ToInt32(txtTimeOut.Text.ToString().Substring(0, 2));
                        int num4 = Convert.ToInt32(txtTimeOut.Text.ToString().Substring(3, 2));

                        if ((num1 < 0 || num1 > 24) || (num3 < 0 || num3 > 24))
                        {
                            MessageBox.Show("There are only 24 hours in a day.\nTime In or Time Out is not in proper format.\nEnter the format like 13:60");
                            txtTimeIn.Text = "";
                            txtTimeOut.Text = "";
                            return;
                        }
                        if ((num2 < 0 || num2 > 60) || (num1 < 0 || num4 > 60))
                        {
                            MessageBox.Show("There are only 60 minutes in an hour.\nTime In or Time Out is not in proper format.\nEnter the format like 13:60");
                            txtTimeIn.Text = "";
                            txtTimeOut.Text = "";
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Time In or Time Out is not in proper format");
                    txtTimeIn.Text = "";
                    txtTimeOut.Text = "";
                    return;
                }



                if (txtEmpID.Text != "HR001")
                {
                    try
                    {
                        dateTimePicker1.Format = DateTimePickerFormat.Custom;
                        dateTimePicker1.CustomFormat = "MMMM";
                        string month = dateTimePicker1.Text;

                        dateTimePicker1.CustomFormat = "";
                        dateTimePicker1.CustomFormat = "dd";
                        string date = dateTimePicker1.Text;
                        dateTimePicker1.CustomFormat = "";
                        dateTimePicker1.CustomFormat = "yyyy";
                        string year = dateTimePicker1.Text;
                        dateTimePicker1.CustomFormat = "";
                        dateTimePicker1.CustomFormat = "dddd";
                        string day = dateTimePicker1.Text;
                        dateTimePicker1.Format = DateTimePickerFormat.Long;
                        //*************************

                        string sql = "SELECT * FROM AttendanceDetails WHERE EmpID=@empid And Date=@date And CurrentMonth=@month And CurrentYear=@yr";
                        SqlCommand SqlCommand1 = con.CreateCommand();
                        SqlCommand1.CommandText = sql;
                        int res;
                        SqlCommand1.Parameters.Add("@empid", SqlDbType.VarChar, 10);
                        SqlCommand1.Parameters.Add("@date", SqlDbType.VarChar, 30);
                        SqlCommand1.Parameters.Add("@month", SqlDbType.VarChar, 30);
                        SqlCommand1.Parameters.Add("@yr", SqlDbType.VarChar, 30);
                        SqlCommand1.Parameters[0].Value = txtEmpID.Text;
                        SqlCommand1.Parameters[1].Value = date;
                        SqlCommand1.Parameters[2].Value = month;
                        SqlCommand1.Parameters[3].Value = year;
                        da = new SqlDataAdapter();
                        da.SelectCommand = SqlCommand1;
                        myDataSet = new System.Data.DataSet();
                        res = da.Fill(myDataSet, "AttendanceDetails");
                        if (res >= 1)
                        {
                            SqlCommand objUpdate = con.CreateCommand();

                            objUpdate.CommandText = "update AttendanceDetails set AttendanceDetails.[EmpID]='" + txtEmpID.Text + "',AttendanceDetails.[FName]='" + txtFName.Text + "',AttendanceDetails.[Department]='" + txtDepartment.Text + "',AttendanceDetails.[Designation]='" + txtDesignation.Text + "',AttendanceDetails.[TimeIn]='" + txtTimeIn.Text + "',AttendanceDetails.[TimeOut]='" + txtTimeOut.Text + "',AttendanceDetails.[OvertimeHours]=" + Convert.ToInt32(txtOvertimeHours.Text) + " WHERE AttendanceDetails.[EmpID]='" + cbEmpID.SelectedItem + "' And AttendanceDetails.[Date]='" + date + "' And AttendanceDetails.[CurrentDay]='" + day + "' And AttendanceDetails.[CurrentMonth]='" + month + "' And AttendanceDetails.[CurrentYear]='" + year + "'";
                            objUpdate.Connection = con;
                            objUpdate.Transaction = objTran;
                            int res2 = objUpdate.ExecuteNonQuery();
                            if (res2 >= 1)
                            {
                                MessageBox.Show("Daily attendance of " + txtFName.Text + " is added.\nDate: " + date + "\nMonth: " + month, "Attendance Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }


                    //******************************
                        else
                        {





                            SqlDataAdapter adp = new SqlDataAdapter("select * from AttendanceDetails", con);
                            DataSet ds = new DataSet();
                            adp.Fill(ds, "AttendanceDetails");
                            int var = ds.Tables["AttendanceDetails"].Rows.Count;

                            DataTable table = null;
                            table = ds.Tables["AttendanceDetails"];

                            DataRow newRow = null;

                            newRow = table.NewRow();

                            newRow["EmpID"] = txtEmpID.Text;
                            newRow["FName"] = txtFName.Text;
                            newRow["Department"] = txtDepartment.Text;

                            newRow["Designation"] = txtDesignation.Text;
                            newRow["Date"] = date;
                            newRow["CurrentDay"] = day;
                            newRow["CurrentMonth"] = month;
                            newRow["CurrentYear"] = year;
                            newRow["TimeIn"] = txtTimeIn.Text;
                            newRow["TimeOut"] = txtTimeOut.Text;
                            newRow["OvertimeHours"] = Convert.ToInt32(txtOvertimeHours.Text);
                            newRow["Remarks"] = txtRemarks.Text;



                            table.Rows.Add(newRow);
                            SqlCommandBuilder commandBuilder = null;
                            commandBuilder = new SqlCommandBuilder(adp);
                            adp.InsertCommand = commandBuilder.GetInsertCommand();
                            adp.Update(ds, "AttendanceDetails");
                            MessageBox.Show("Daily attendance of " + txtFName.Text + " is added.\nDate: " + date + "\nMonth: " + month, "Attendance Added", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Provided data not in a correct format");
                    }
                }
                else
                {
                    MessageBox.Show("HR001 is Admin record, its attendance request is rejected.", "Daily Attendance Request Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtTimeIn_TextChanged(object sender, EventArgs e)
        {
            string str = txtTimeIn.Text.ToString();
            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                {
                    MessageBox.Show("Please Enter Numbers in hh:mm format");
                    txtTimeIn.Text = "";
                    return;
                }
            }


        }

        private void txtTimeOut_TextChanged(object sender, EventArgs e)
        {
            string str = txtTimeOut.Text.ToString();
            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                {
                    MessageBox.Show("Please Enter Numbers in hh:mm format");
                    txtTimeOut.Text = "";
                    return;
                }
            }

        }

    }
}
