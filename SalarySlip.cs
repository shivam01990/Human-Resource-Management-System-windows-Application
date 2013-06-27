using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace HumanResourceManagementSystem
{
    public partial class SalarySlip : Form
    {
        SqlConnection con;
        SqlCommand SqlCommand1;
        int count, days, hrs, leavededuction, overtimepayment, monthlysalary, basic, hra, da, ua, conv, telephone, medical, prof, pf, grossearn, grossdeduct, total;
        string empid, name, dept, desig, month, yr, bankname, accno;
        StringReader myReader;
        public SalarySlip()
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalaryReportAll_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            SalaryReportofEmployee esa = new SalaryReportofEmployee();
            dr = esa.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rbSalaryReport.Checked == false && rbSalarySlip.Checked == false)
            {
                MessageBox.Show("Either select Get Salary Slip option or Get Salary Report option");
            }
            else
            {
                printDialog1.Document = printDocument1;
                string strText = rtbSalarySlip.Text;
                myReader = new StringReader(strText);
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.printDocument1.Print();
                }
            }

        }

        private void rbSalarySlip_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSalarySlip.Checked == true)
            {
                if (txtYear.Text == "")
                {
                    MessageBox.Show("Please enter Year");
                    rbSalarySlip.Checked = false;
                    return;
                }

                if (cmbMonth.Text == "")
                {
                    MessageBox.Show("Please select a Month");
                    rbSalarySlip.Checked = false;
                    return;
                }
                if (cmbEmpID.Text == "")
                {
                    MessageBox.Show("Please select an Employee ID");
                    rbSalarySlip.Checked = false;
                    return;
                }
                if (txtYear.Text != "" && cmbMonth.Text != "" && cmbEmpID.Text != "")
                {
                    if (cmbEmpID.Text != "HR001")
                    {
                        try
                        {
                            SqlDataAdapter adp1 = new SqlDataAdapter("Select * from EmployeeSalaryAgreement where EmpID = '" + cmbEmpID.SelectedItem + "'", con);
                            DataSet ds1 = new DataSet();
                            adp1.Fill(ds1);
                            SqlDataAdapter adp2 = new SqlDataAdapter("Select * from SalaryDetails where EmpID = '" + cmbEmpID.SelectedItem + "' And YearOfSalary = '" + txtYear.Text + "' And MonthOfSalary = '" + cmbMonth.SelectedItem + "'", con);
                            DataSet ds2 = new DataSet();
                            adp2.Fill(ds2);

                            empid = ds1.Tables[0].Rows[0]["EmpID"].ToString();
                            name = ds1.Tables[0].Rows[0]["FName"].ToString();
                            dept = ds1.Tables[0].Rows[0]["Department"].ToString();
                            desig = ds1.Tables[0].Rows[0]["Designation"].ToString();
                            basic = Convert.ToInt32(ds1.Tables[0].Rows[0]["Basic"].ToString());
                            hra = Convert.ToInt32(ds1.Tables[0].Rows[0]["HRA"].ToString());
                            da = Convert.ToInt32(ds1.Tables[0].Rows[0]["DA"].ToString());
                            ua = Convert.ToInt32(ds1.Tables[0].Rows[0]["UA"].ToString());
                            conv = Convert.ToInt32(ds1.Tables[0].Rows[0]["ConveyanceAllowance"].ToString());
                            telephone = Convert.ToInt32(ds1.Tables[0].Rows[0]["Telephone"].ToString());
                            medical = Convert.ToInt32(ds1.Tables[0].Rows[0]["MR"].ToString());
                            prof = Convert.ToInt32(ds1.Tables[0].Rows[0]["ProfessionTax"].ToString());
                            pf = Convert.ToInt32(ds1.Tables[0].Rows[0]["PF"].ToString());

                            month = ds2.Tables[0].Rows[0]["MonthOfSalary"].ToString();
                            yr = ds2.Tables[0].Rows[0]["YearOfSalary"].ToString();
                            monthlysalary = Convert.ToInt32(ds2.Tables[0].Rows[0]["FixedSalary"].ToString());
                            days = Convert.ToInt32(ds2.Tables[0].Rows[0]["NoOfLeaves"].ToString());
                            hrs = Convert.ToInt32(ds2.Tables[0].Rows[0]["OvertimeHours"].ToString());
                            leavededuction = Convert.ToInt32(ds2.Tables[0].Rows[0]["TotalDeduction"].ToString());
                            overtimepayment = Convert.ToInt32(ds2.Tables[0].Rows[0]["OvertimePayments"].ToString());
                            total = Convert.ToInt32(ds2.Tables[0].Rows[0]["TotalSalary"].ToString());
                            grossearn = basic + hra + da + ua + conv + telephone + medical + overtimepayment;
                            grossdeduct = prof + pf + leavededuction;



                            rtbSalarySlip.Text = "                                                                   Pay Slip" + '\r';
                            rtbSalarySlip.Text += "                                            HUMAN RESOURCE MANAGEMENT SYSTEM" + '\r';
                            rtbSalarySlip.Text += "                                                                                                     For the Month of :" + month + " " + yr + '\r';
                            rtbSalarySlip.Text += '\r' + "------------------------------------------------------------------------------------------------------------------------------------------------------------------" + '\r';
                            rtbSalarySlip.Text += '\t' + "EmployeeID :" + empid + '\r';
                            rtbSalarySlip.Text += '\t' + "Name :" + name + '\r';
                            rtbSalarySlip.Text += '\t' + "Department :" + dept + '\r';
                            rtbSalarySlip.Text += '\t' + "Designation :" + desig + '\r';

                            rtbSalarySlip.Text += '\r' + "------------------------------------------------------------------------------------------------------------------------------------------------------------------" + '\r';
                            rtbSalarySlip.Text += '\t' + "Gross Earning from" + '\r' + '\r';
                            rtbSalarySlip.Text += '\t' + "Basic Salary:" + '\t' + '\t' + basic + '\r';
                            rtbSalarySlip.Text += '\t' + "HRA:" + '\t' + '\t' + '\t' + hra + '\r';
                            rtbSalarySlip.Text += '\t' + "DA:" + '\t' + '\t' + '\t' + da + '\r';
                            rtbSalarySlip.Text += '\t' + "UA:" + '\t' + '\t' + '\t' + ua + '\r';
                            rtbSalarySlip.Text += '\t' + "Conveyance:" + '\t' + '\t' + conv + '\r';
                            rtbSalarySlip.Text += '\t' + "Telephone:" + '\t' + '\t' + telephone + '\r';
                            rtbSalarySlip.Text += '\t' + "Medical:" + '\t' + '\t' + '\t' + medical + '\r';
                            rtbSalarySlip.Text += '\t' + "Overtime Payments:*" + '\t' + overtimepayment + '\r';

                            rtbSalarySlip.Text += '\r' + "------------------------------------------------------------------------------------------------------------------------------------------------------------------" + '\r';
                            rtbSalarySlip.Text += '\t' + "Gross Earning:" + '\t' + '\t' + grossearn + '\r';
                            rtbSalarySlip.Text += '\r' + "------------------------------------------------------------------------------------------------------------------------------------------------------------------" + '\r';
                            rtbSalarySlip.Text += '\t' + "Deduction For" + '\r' + '\r';

                            rtbSalarySlip.Text += '\t' + "Professional Tax:" + '\t' + '\t' + prof + '\r';
                            rtbSalarySlip.Text += '\t' + "PF:" + '\t' + '\t' + '\t' + pf + '\r';
                            rtbSalarySlip.Text += '\t' + "Leave Deduction:**" + '\t' + '\t' + leavededuction + '\r';
                            rtbSalarySlip.Text += '\r' + "------------------------------------------------------------------------------------------------------------------------------------------------------------------" + '\r';
                            rtbSalarySlip.Text += '\t' + "Gross Deduction:" + '\t' + '\t' + grossdeduct + '\r';
                            rtbSalarySlip.Text += '\r' + "------------------------------------------------------------------------------------------------------------------------------------------------------------------" + '\r';
                            rtbSalarySlip.Text += '\t' + "Net Payment:" + '\t' + '\t' + total + '\r';
                            rtbSalarySlip.Text += '\r' + "------------------------------------------------------------------------------------------------------------------------------------------------------------------" + '\r';
                            rtbSalarySlip.Text += "*Overtime Hours :" + hrs + '\r';
                            rtbSalarySlip.Text += "**Absent Days :" + days + '\r';
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Salary details do not exist");
                        }
                    }
                    else
                    {
                        MessageBox.Show("HR001 is Admin record, its salary slip not found.", "Salary Slip not generated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rbSalaryReport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSalaryReport.Checked == true)
            {
                if (txtYear.Text == "")
                {
                    MessageBox.Show("Please enter Year");

                    return;
                }

                if (cmbMonth.Text == "")
                {
                    MessageBox.Show("Please select a Month");

                    return;
                }
                if (cmbEmpID.Text == "")
                {
                    MessageBox.Show("Please select an Employee ID");

                    return;
                }
                try
                {
                    if (cmbEmpID.Text != "HR001")
                    {
                        SqlDataAdapter adp = new SqlDataAdapter("Select * from SalaryDetails where EmpID = '" + cmbEmpID.SelectedItem + "' And YearOfSalary = '" + txtYear.Text + "' And MonthOfSalary = '" + cmbMonth.SelectedItem + "'", con);
                        DataSet ds = new DataSet();
                        adp.Fill(ds);

                        empid = ds.Tables[0].Rows[0]["EmpID"].ToString();
                        name = ds.Tables[0].Rows[0]["FName"].ToString();
                        dept = ds.Tables[0].Rows[0]["Department"].ToString();
                        desig = ds.Tables[0].Rows[0]["Designation"].ToString();
                        bankname = ds.Tables[0].Rows[0]["BankName"].ToString();
                        accno = ds.Tables[0].Rows[0]["AccountNo"].ToString();
                        month = ds.Tables[0].Rows[0]["MonthOfSalary"].ToString();
                        yr = ds.Tables[0].Rows[0]["YearOfSalary"].ToString();
                        monthlysalary = Convert.ToInt32(ds.Tables[0].Rows[0]["FixedSalary"].ToString());
                        days = Convert.ToInt32(ds.Tables[0].Rows[0]["NoOfLeaves"].ToString());
                        hrs = Convert.ToInt32(ds.Tables[0].Rows[0]["OvertimeHours"].ToString());
                        leavededuction = Convert.ToInt32(ds.Tables[0].Rows[0]["TotalDeduction"].ToString());
                        overtimepayment = Convert.ToInt32(ds.Tables[0].Rows[0]["OvertimePayments"].ToString());
                        total = Convert.ToInt32(ds.Tables[0].Rows[0]["TotalSalary"].ToString());


                        rtbSalarySlip.Text = "                                                               Salary Details" + '\r';
                        rtbSalarySlip.Text += "                                            HUMAN RESOURCE MANAGEMENT SYSTEM" + '\r';
                        rtbSalarySlip.Text += "\t\t\t\t\t\t\tDate of Issue: " + System.DateTime.Today.ToShortDateString() + '\r';
                        rtbSalarySlip.Text += '\r' + "------------------------------------------------------------------------------------------------------------------------------------------------------------------" + '\r';
                        rtbSalarySlip.Text += '\t' + "EmployeeID :" + empid + '\r';
                        rtbSalarySlip.Text += '\t' + "Name :" + name + '\r';
                        rtbSalarySlip.Text += '\t' + "Department :" + dept + '\t' + '\t' + '\t' + '\t' + '\r';
                        rtbSalarySlip.Text += '\t' + "Designation :" + desig + '\r';
                        rtbSalarySlip.Text += '\t' + "Bank Name :" + bankname + '\r';
                        rtbSalarySlip.Text += '\t' + "Account No. :" + accno + '\r';
                        rtbSalarySlip.Text += '\r' + "------------------------------------------------------------------------------------------------------------------------------------------------------------------" + '\r';
                        rtbSalarySlip.Text += "\t\t\t\t" + month + "/" + yr + '\r' + '\r';
                        rtbSalarySlip.Text += '\t' + "Leave Deduction for " + days + " days" + '\t' + '\t' + leavededuction + '\r';
                        rtbSalarySlip.Text += '\t' + "Overtime Payments for " + hrs + " hours" + '\t' + overtimepayment + '\r';

                        rtbSalarySlip.Text += '\r' + "------------------------------------------------------------------------------------------------------------------------------------------------------------------" + '\r';
                        rtbSalarySlip.Text += '\t' + "Net Payment:" + '\t' + '\t' + total + '\r';
                        rtbSalarySlip.Text += '\r' + "------------------------------------------------------------------------------------------------------------------------------------------------------------------" + '\r';
                    }
                    else
                    {
                        MessageBox.Show("HR001 is Admin record, its salary report not found.", "Salary Report not generated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Salary details do not exist");
                }

            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            if (rtbSalarySlip.Text != null)
            {
                float linesPerPage = 0;
                float yPosition = 0;
                int count = 0;
                float leftMargin = e.MarginBounds.Left;
                float topMargin = e.MarginBounds.Top;
                string line = null;
                Font printFont = rtbSalarySlip.Font;
                SolidBrush myBrush = new SolidBrush(Color.Black);

                // Work out the number of lines per page, using the MarginBounds.
                linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
                // Iterate over the string using the StringReader, printing each line.
                while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
                {
                    // calculate the next line position based on 
                    // the height of the font according to the printing device
                    yPosition = topMargin + (count * printFont.GetHeight(e.Graphics));
                    // draw the next line in the rich edit control
                    e.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                    count++;
                }
                // If there are more lines, print another page.
                if (line != null)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;

                myBrush.Dispose();

            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            rbSalarySlip.Checked = false;
            rbSalaryReport.Checked = false;
            rtbSalarySlip.Text = "";
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbSalarySlip.Checked = false;
            rbSalaryReport.Checked = false;
            rtbSalarySlip.Text = "";
        }

        private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbSalarySlip.Checked = false;
            rbSalaryReport.Checked = false;
            rtbSalarySlip.Text = "";
        }
    }
}
