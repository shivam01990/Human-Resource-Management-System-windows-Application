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
    public partial class UpdateSalaryAgreement : Form
    {
        SqlConnection con;
        SqlCommand SqlCommand1;
        SqlDataAdapter adp;
        int count, days, whr;
        DataSet myDataSet;
        SqlTransaction objTran;
        int basic, hra, da, ua, conv, tele, med, prof, pf, monthlysalary, salaryperday, salaryperhour, total;

        public UpdateSalaryAgreement()
        {
            InitializeComponent();
            con = new SqlConnection(GlobalClass.conn);
            con.Open();
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
        private void txtBasic_TextChanged(object sender, EventArgs e)
        {
            if (txtBasic.Text == "")
            {
                basic = 0;
            }
            else
            {
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
                pf = Convert.ToInt32(txtPF.Text);
            }

            total = basic + hra + da + ua + conv + tele + med - prof - pf;
            txtTotalSalary.Text = total.ToString();
        }

        private void cbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmpID.SelectedIndex != -1)
            {
                string sql = "SELECT * FROM EmployeeSalaryAgreement WHERE EmpID=@empid";
                SqlCommand SqlCommand1 = con.CreateCommand();
                SqlCommand1.CommandText = sql;
                int res;
                SqlCommand1.Parameters.Add("@empid", SqlDbType.VarChar, 10);
                SqlCommand1.Parameters[0].Value = cbEmpID.SelectedItem;
                adp = new SqlDataAdapter();
                adp.SelectCommand = SqlCommand1;
                myDataSet = new System.Data.DataSet();
                res = adp.Fill(myDataSet, "EmployeeSalaryAgreement");

                if (res >= 1)
                {
                    txtAgreementDate.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["AgreementDate"].ToString();
                    txtFName.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["FName"].ToString();
                    txtDepartment.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["Department"].ToString();
                    txtDesignation.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["Designation"].ToString();
                    txtBankName.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["BankName"].ToString();
                    txtAccNo.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["AccountNo"].ToString();
                    txtPayFrequency.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["PayFrequency"].ToString();
                    txtWorkingDays.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["WorkingDays"].ToString();
                    txtWorkingHours.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["WorkingHours"].ToString();
                    txtBasic.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["Basic"].ToString();
                    txtHra.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["HRA"].ToString();
                    txtDa.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["DA"].ToString();
                    txtUa.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["UA"].ToString();
                    txtConveyance.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["ConveyanceAllowance"].ToString();
                    txtTelephone.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["Telephone"].ToString();
                    txtMr.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["MR"].ToString();
                    txtPTax.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["ProfessionTax"].ToString();
                    txtPF.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["PF"].ToString();
                    txtRemarks.Text = myDataSet.Tables["EmployeeSalaryAgreement"].Rows[0]["Remarks"].ToString();

                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = cbEmpID.Text;

            if (str == "")
            {
                MessageBox.Show("You must select a Employee ID");
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
                string str2 = txtBankName.Text.ToString();
                foreach (char c in str2)
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
                string str2 = txtAccNo.Text.ToString();
                foreach (char c in str2)
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
                if (txtPayFrequency.Text == "Annually")
                {
                    int sal = Convert.ToInt32(txtTotalSalary.Text);
                    monthlysalary = sal / 12;
                }
                else
                {
                    monthlysalary = Convert.ToInt32(txtTotalSalary.Text);
                }

                salaryperday = monthlysalary / days;

                salaryperhour = monthlysalary / (days * whr);
                if (cbEmpID.Text != "HR001")
                {
                    try
                    {
                        SqlCommand objUpdate = con.CreateCommand();

                        objUpdate.CommandText = "update EmployeeSalaryAgreement set AgreementDate='" + txtAgreementDate.Text + "',PayFrequency = '" + txtPayFrequency.Text + "', WorkingDays = '" + txtWorkingDays.Text + "', WorkingHours = '" + txtWorkingHours.Text + "', Basic = '" + txtBasic.Text + "', HRA = '" + txtHra.Text + "', DA = '" + txtDa.Text + "', UA = '" + txtUa.Text + "', ConveyanceAllowance = '" + txtConveyance.Text + "', Telephone = '" + txtTelephone.Text + "', MR = '" + txtMr.Text + "', ProfessionTax = '" + txtPTax.Text + "', PF = '" + txtPF.Text + "', MonthlySalary='" + monthlysalary.ToString() + "', SalaryPerDay='" + salaryperday.ToString() + "', OvertimePerHour='" + salaryperhour.ToString() + "', Remarks = '" + txtRemarks.Text + "', TotalSalary = '" + txtTotalSalary.Text + "' where EmpID = '" + cbEmpID.SelectedItem + "'";
                        objUpdate.Connection = con;
                        objUpdate.Transaction = objTran;
                        int res = objUpdate.ExecuteNonQuery();
                        if (res >= 1)
                        {
                            MessageBox.Show("Employee's information is updated.");
                            txtAgreementDate.Text = System.DateTime.Today.ToString();

                            cbEmpID.SelectedIndex = -1;
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
                            return;
                        }

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("HR001 is Admin record, its salary agreement cannot be settled.", "Salary Agreement Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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
