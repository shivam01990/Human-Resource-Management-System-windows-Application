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
    public partial class HRAddNewEmployee : Form
    {
        SqlConnection con;
        public HRAddNewEmployee()
        {
            InitializeComponent();
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (firstname_text1.Text == "")
            {
                MessageBox.Show("Please Enter Name");
                return;
            }
            if (empdet_text1.Text == "")
            {
                MessageBox.Show("Please Enter Employee ID");
                return;
            }
            if (empswd_text1.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                return;
            }
            if (dept_text1.Text == "")
            {
                MessageBox.Show("Please Select the Department");
                return;
            }
            if (address_text1.Text == "")
            {
                MessageBox.Show("Please Enter Address");
                return;
            }
            if (phone_text1.Text != "")
            {

                int i = 0;
                string str = phone_text1.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("You cannot enter characters in Phone Number");
                        phone_text1.Text = "";
                        return;
                    }

                    i = i + 1;
                    if (i > 10)
                    {
                        MessageBox.Show("Phone number is not in proper format");
                        phone_text1.Text = "";
                        return;
                    }

                }
            }
            if (cell_text1.Text != "")
            {
                int i = 0;
                string str = cell_text1.Text.ToString();
                foreach (char c in str)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("You cannot enter characters in Cell Number");
                        cell_text1.Text = "";
                        return;
                    }
                    i = i + 1;
                    if (i > 10)
                    {
                        MessageBox.Show("Mobile number is not in proper format");
                        cell_text1.Text = "";
                        return;
                    }
                }
            }
            if (sex_text1.Text == "" | sex_text1.Text == "select one")
            {
                MessageBox.Show("Please Select Sex");
                return;
            }
            if (education_text1.Text == "")
            {
                MessageBox.Show("Please Enter Education");
                return;
            }

            if (desig_text1.Text == "")
            {
                MessageBox.Show("Please Select Designation");
                return;
            }
            if (doj_text1.Text == "")
            {
                MessageBox.Show("Please Select Date Of Joining in the company");
                return;
            }
            if (Convert.ToDateTime(doj_text1.Text) <= Convert.ToDateTime(dob_text1.Text))
            {
                MessageBox.Show("Date of Joining must be greater than Date of Birth. Please Check!!!");
                return;
            }

            else
            {
                if (email_text1.Text != "")
                {
                    bool validval1 = false, validval2 = false;
                    string str = email_text1.Text.ToString();
                    foreach (char c in str)
                    {
                        if (c == '@')
                        {
                            validval1 = true;
                            break;
                        }
                    }
                    foreach (char c in str)
                    {
                        if (c == '.')
                        {
                            validval2 = true;
                            break;
                        }
                    }
                    if (validval1 == false || validval2 == false)
                    {
                        MessageBox.Show("Email address is not in proper format.\nPlease enter the address like-charu@kogentindia.com");
                        email_text1.Text = "";
                        return;
                    }

                }

                try
                {

                    con = new System.Data.SqlClient.SqlConnection(GlobalClass.conn);
                    con.Open();
                    SqlDataAdapter adp = new SqlDataAdapter("select * from EmployeeDetails", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "EmployeeDetails");
                    int var = ds.Tables["EmployeeDetails"].Rows.Count;

                    DataTable table = null;
                    table = ds.Tables["EmployeeDetails"];

                    DataRow newRow = null;

                    newRow = table.NewRow();

                    newRow["EmpID"] = empdet_text1.Text;
                    newRow["FName"] = firstname_text1.Text;

                    newRow["MName"] = middlename_text1.Text;
                    newRow["LName"] = lastname_text1.Text;
                    newRow["Password"] = empswd_text1.Text;
                    newRow["Department"] = dept_text1.Text;

                    newRow["Address"] = address_text1.Text;
                    newRow["Phone"] = phone_text1.Text;

                    newRow["Mobile"] = cell_text1.Text;
                    newRow["Dob"] = dob_text1.Text;
                    newRow["Sex"] = sex_text1.Text;
                    newRow["Education"] = education_text1.Text;

                    newRow["Designation"] = desig_text1.Text;
                    newRow["Email"] = email_text1.Text;

                    newRow["Doj"] = doj_text1.Text;

                    table.Rows.Add(newRow);
                    SqlCommandBuilder commandBuilder = null;
                    commandBuilder = new SqlCommandBuilder(adp);
                    adp.InsertCommand = commandBuilder.GetInsertCommand();
                    adp.Update(ds, "EmployeeDetails");
                    con.Close();

                    MessageBox.Show("New Account of " + firstname_text1.Text + " is Created\nLogin Name: " + empdet_text1.Text + "\nPassword: " + empswd_text1.Text, "Account Created",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    empdet_text1.Text = "";
                    firstname_text1.Text = "";
                    empswd_text1.Text = "";
                    middlename_text1.Text = "";
                    lastname_text1.Text = "";
                    dept_text1.SelectedIndex = -1;
                    desig_text1.SelectedIndex = -1;
                    address_text1.Text = "";
                    phone_text1.Text = "";
                    email_text1.Text = "";
                    cell_text1.Text = "";
                    education_text1.Text = "";
                    sex_text1.SelectedIndex = -1;

                }
                catch (Exception exc)
                {

                    MessageBox.Show("Employee ID is not available.\nPlease choose another Employee ID\n");
                    empdet_text1.Focus();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {


            this.Hide();

        }

        private void empdet_text1_TextChanged(object sender, EventArgs e)
        {
            if (empdet_text1.Text == "HR001")
            {
                MessageBox.Show("This is Admin ID. Please Choose another ID");
                empdet_text1.Text = "";
            }
        }

        

    }
}
