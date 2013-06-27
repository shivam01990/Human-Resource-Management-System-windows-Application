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
    public partial class EmployeeSalaryAgreement : Form
    {
        SqlConnection con;

        SqlCommand SqlCommand1;
        SqlDataAdapter adp;
        int count;
        DataSet myDataSet;
        int days, whr;
        int basic, hra, da, ua, conv, tele, med, prof, pf, monthlysalary, salaryperday, salaryperhour, total;
       
        public EmployeeSalaryAgreement()
        {
            InitializeComponent();
            con = new SqlConnection(GlobalClass.conn);
            con.Open();
            string sql = "SELECT EmpID FROM EmployeeDetails where EmpID Not IN(Select EmpID from EmployeeSalaryAgreement)And EmpID NOT IN('HR001') And status IS NULL";
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
                adp = new SqlDataAdapter();
                adp.SelectCommand = SqlCommand1;
                myDataSet = new System.Data.DataSet();
                res = adp.Fill(myDataSet, "EmployeeDetails");

                if (res >= 1)
                {


                    txtFName.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["FName"].ToString();

                    txtAgreementDate.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Doj"].ToString();

                    txtDepartment.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Department"].ToString();
                    txtDesignation.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Designation"].ToString();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbEmpID.Text == "")
            {
                MessageBox.Show("Please select an Employee ID first");

                return;
            }
            if (txtBankName.Text == "")
            {
                MessageBox.Show("Please Enter Bank Name");
                txtBankName.Focus();
                return;
            }
            if (txtBankName.Text != "")
            {
                string str = txtBankName.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsDigit(c))
                    {
                        MessageBox.Show("Please Enter Bank Name Properly");
                        txtBankName.Text = "";
                        return;
                    }
                }
            }
            if (txtAccNo.Text == "")
            {
                MessageBox.Show("Please Enter Account Number");
                txtAccNo.Focus();
                return;

            }

            if (txtAccNo.Text != "")
            {
                string str = txtAccNo.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("You cannot enter characters in Account Number");
                        txtAccNo.Text = "";

                        return;
                    }
                }
            }
            if (txtPayFrequency.Text == "")
            {
                MessageBox.Show("Please select a pay frequency");
                txtPayFrequency.Focus();
                return;

            }
            if (txtWorkingDays.Text == "")
            {
                MessageBox.Show("Please Enter Working Days");
                txtWorkingDays.Focus();
                return;

            }


            if (txtWorkingHours.Text == "")
            {
                MessageBox.Show("Please Enter Working Hours");
                txtWorkingHours.Focus();
                return;

            }


            else
            {

                salaryperday = monthlysalary / days;

                salaryperhour = monthlysalary / (days * whr);
                try
                {
                    if (cbEmpID.Text != "HR001")
                    {

                        con = new System.Data.SqlClient.SqlConnection(GlobalClass.conn);
                        con.Open();
                        SqlDataAdapter adp2 = new SqlDataAdapter("select * from EmployeeSalaryAgreement", con);
                        DataSet ds = new DataSet();
                        adp2.Fill(ds, "EmployeeSalaryAgreement");
                        int var = ds.Tables["EmployeeSalaryAgreement"].Rows.Count;

                        DataTable table = null;
                        table = ds.Tables["EmployeeSalaryAgreement"];

                        DataRow newRow = null;

                        newRow = table.NewRow();

                        newRow["EmpID"] = cbEmpID.Text;
                        newRow["AgreementDate"] = txtAgreementDate.Text;
                        newRow["FName"] = txtFName.Text;
                        newRow["Department"] = txtDepartment.Text;
                        newRow["Designation"] = txtDesignation.Text;
                        newRow["BankName"] = txtBankName.Text;
                        newRow["AccountNo"] = txtAccNo.Text;
                        newRow["PayFrequency"] = txtPayFrequency.Text;
                        newRow["WorkingDays"] = txtWorkingDays.Text;
                        newRow["WorkingHours"] = txtWorkingHours.Text;
                        newRow["Basic"] = txtBasic.Text;
                        newRow["HRA"] = txtHra.Text;
                        newRow["DA"] = txtDa.Text;
                        newRow["UA"] = txtUa.Text;
                        newRow["ConveyanceAllowance"] = txtConveyance.Text;
                        newRow["Telephone"] = txtTelephone.Text;
                        newRow["MR"] = txtMr.Text;
                        newRow["ProfessionTax"] = txtPTax.Text;
                        newRow["PF"] = txtPF.Text;
                        newRow["TotalSalary"] = txtTotalSalary.Text;
                        newRow["MonthlySalary"] = monthlysalary;
                        newRow["SalaryPerDay"] = salaryperday;
                        newRow["OvertimePerHour"] = salaryperhour;
                        newRow["Remarks"] = txtRemarks.Text;



                        table.Rows.Add(newRow);
                        SqlCommandBuilder commandBuilder = null;
                        commandBuilder = new SqlCommandBuilder(adp2);
                        adp2.InsertCommand = commandBuilder.GetInsertCommand();
                        adp2.Update(ds, "EmployeeSalaryAgreement");
                        MessageBox.Show("Salary Agreement Details of " + txtFName.Text + " is added.\nDate: " + txtAgreementDate.Text, "Salary Agreement Details Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAgreementDate.Text = "";

                        txtFName.Text = "";
                        txtDepartment.Text = "";
                        txtDesignation.Text = "";
                        txtBankName.Text = "";
                        txtAccNo.Text = "";
                        txtPayFrequency.SelectedIndex = -1;
                        txtWorkingDays.Text = "";
                        txtWorkingHours.Text = "";
                        txtBasic.Text = "0";
                        txtHra.Text = "0";
                        txtDa.Text = "0";
                        txtUa.Text = "0";
                        txtConveyance.Text = "0";
                        txtTelephone.Text = "0";
                        txtMr.Text = "0";
                        txtPTax.Text = "0";
                        txtPF.Text = "0";
                        txtTotalSalary.Text = "0";
                        txtRemarks.Text = "";

                        cbEmpID.Items.Clear();
                        string sql = "SELECT EmpID FROM EmployeeDetails where EmpID Not IN(Select EmpID from EmployeeSalaryAgreement)And EmpID NOT IN('HR001') And status IS NULL";
                        SqlCommand1 = new SqlCommand(sql, con);
                        SqlDataReader dr = SqlCommand1.ExecuteReader();
                        while (dr.Read())
                        {
                            cbEmpID.Items.Add(dr[0]);
                            count++;
                        }

                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("HR001 is Admin record, its salary agreement cannot be settled.", "Salary Agreement Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error");
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



















        private void txtBasic_TextChanged(object sender, EventArgs e)
        {
            if (txtBasic.Text == "")
            {
                basic = 0;
            }
            else
            {
                string str = txtBasic.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("Please Enter only Number");
                        txtBasic.Text = "";
                        return;
                    }
                }
                basic = Convert.ToInt32(txtBasic.Text);
            }

            total = basic + hra + da + ua + conv + tele + med - prof - pf;
            txtTotalSalary.Text = total.ToString();
        }

        private void txtHra_TextChanged(object sender, EventArgs e)
        {
            if (txtHra.Text == "")
            {
                hra = 0;
            }
            else
            {
                string str = txtHra.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("Please Enter only Number");
                        txtHra.Text = "";
                        return;
                    }
                }
                hra = Convert.ToInt32(txtHra.Text);
            }

            total = basic + hra + da + ua + conv + tele + med - prof - pf;
            txtTotalSalary.Text = total.ToString();
        }

        private void txtDa_TextChanged(object sender, EventArgs e)
        {
            if (txtDa.Text == "")
            {
                da = 0;
            }
            else
            {
                string str = txtDa.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("Please Enter only Number");
                        txtDa.Text = "";
                        return;
                    }
                }
                da = Convert.ToInt32(txtDa.Text);
            }

            total = basic + hra + da + ua + conv + tele + med - prof - pf;
            txtTotalSalary.Text = total.ToString();
        }

        private void txtUa_TextChanged(object sender, EventArgs e)
        {
            if (txtUa.Text == "")
            {
                ua = 0;
            }
            else
            {
                string str = txtUa.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("Please Enter only Number");
                        txtUa.Text = "";
                        return;
                    }
                }
                ua = Convert.ToInt32(txtUa.Text);
            }

            total = basic + hra + da + ua + conv + tele + med - prof - pf;
            txtTotalSalary.Text = total.ToString();
        }

        private void txtConveyance_TextChanged(object sender, EventArgs e)
        {
            if (txtConveyance.Text == "")
            {
                conv = 0;
            }
            else
            {
                string str = txtConveyance.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("Please Enter only Number");
                        txtConveyance.Text = "";
                        return;
                    }
                }
                conv = Convert.ToInt32(txtConveyance.Text);
            }

            total = basic + hra + da + ua + conv + tele + med - prof - pf;
            txtTotalSalary.Text = total.ToString();
        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {
            if (txtTelephone.Text == "")
            {
                tele = 0;
            }
            else
            {
                string str = txtTelephone.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("Please Enter only Number");
                        txtTelephone.Text = "";
                        return;
                    }
                }
                tele = Convert.ToInt32(txtTelephone.Text);
            }

            total = basic + hra + da + ua + conv + tele + med - prof - pf;
            txtTotalSalary.Text = total.ToString();
        }

        private void txtMr_TextChanged(object sender, EventArgs e)
        {
            if (txtMr.Text == "")
            {
                med = 0;
            }
            else
            {
                string str = txtMr.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("Please Enter only Number");
                        txtMr.Text = "";
                        return;
                    }
                }
                med = Convert.ToInt32(txtMr.Text);
            }

            total = basic + hra + da + ua + conv + tele + med - prof - pf;
            txtTotalSalary.Text = total.ToString();
        }

        private void txtPTax_TextChanged(object sender, EventArgs e)
        {
            if (txtPTax.Text == "")
            {
                prof = 0;
            }
            else
            {
                string str = txtPTax.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("Please Enter only Number");
                        txtPTax.Text = "";
                        return;
                    }
                }
                prof = Convert.ToInt32(txtPTax.Text);
            }

            total = basic + hra + da + ua + conv + tele + med - prof - pf;
            txtTotalSalary.Text = total.ToString();
        }

        private void txtPF_TextChanged(object sender, EventArgs e)
        {
            if (txtPF.Text == "")
            {
                pf = 0;
            }
            else
            {
                string str = txtPF.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("Please Enter only Number");
                        txtPF.Text = "";
                        return;
                    }
                }
                pf = Convert.ToInt32(txtPF.Text);
            }

            total = basic + hra + da + ua + conv + tele + med - prof - pf;
            txtTotalSalary.Text = total.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            this.Close();
            UpdateSalaryAgreement usa = new UpdateSalaryAgreement();
            usa.ShowDialog();
        }

        private void txtWorkingDays_TextChanged(object sender, EventArgs e)
        {

            if (txtWorkingDays.Text != "")
            {
                try
                {
                    string str = txtWorkingDays.Text.ToString();
                    foreach (char c in str)
                    {
                        if (Char.IsLetter(c))
                        {
                            MessageBox.Show("You cannot enter characters in Working Days");
                            txtWorkingDays.Text = "";

                            return;
                        }
                    }
                    days = Convert.ToInt32(txtWorkingDays.Text);
                    if (days < 1 || days > 31)
                    {
                        MessageBox.Show("Working days are not in proper format.\nThere are only 31 days in a month.");
                        txtWorkingDays.Text = "";

                        return;
                    }
                    else
                    {
                        if (txtPayFrequency.Text == "Annually")
                        {
                            int sal = Convert.ToInt32(txtTotalSalary.Text);
                            monthlysalary = sal / 12;
                        }
                        else
                        {
                            monthlysalary = Convert.ToInt32(txtTotalSalary.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Working days are not in proper format.\nThere are only 31 days in a month.");
                    txtWorkingDays.Text = "";

                    return;
                }

            }


        }



        private void txtWorkingHours_TextChanged(object sender, EventArgs e)
        {
            if (txtWorkingHours.Text != "")
            {
                try
                {
                    string str = txtWorkingHours.Text.ToString();
                    foreach (char c in str)
                    {
                        if (Char.IsLetter(c))
                        {
                            MessageBox.Show("You cannot enter characters in Working Hours");
                            txtWorkingHours.Text = "";

                            return;
                        }
                    }
                    whr = Convert.ToInt32(txtWorkingHours.Text);
                    if (whr > 24)
                    {
                        MessageBox.Show("There are 24 hours in a day. Please check");
                        txtWorkingHours.Text = "";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There are 24 hours in a day. Please check");
                    txtWorkingHours.Text = "";
                    return;
                }
            }
        }

    }
}
