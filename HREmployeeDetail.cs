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
    public partial class HREmployeeDetail : Form
    {
        SqlConnection con;
        SqlTransaction objTran;

        SqlCommand SqlCommand1;
        SqlDataAdapter da;
        int count;
        DataSet myDataSet;

        string str2;
        public HREmployeeDetail()
        {
            InitializeComponent();
            str2 = btnUpdate.Text;
            con = new SqlConnection(GlobalClass.conn);
            con.Open();
            cbEmpID.Items.Clear();
            string sql;
            if (GlobalClass.EmpID == "admin")
            {
                sql = "SELECT EmpID FROM EmployeeDetails WHERE status IS NULL";
            }
            else
            {
                sql = "SELECT EmpID FROM EmployeeDetails WHERE EmpID NOT IN('HR001') And status IS NULL";
            }

            SqlCommand1 = new SqlCommand(sql, con);
            SqlDataReader dr = SqlCommand1.ExecuteReader();
            while (dr.Read())
            {
                cbEmpID.Items.Add(dr[0]);
                count++;
            }

            dr.Close();
        }
        private void HREmployeeDetail_Load(object sender, EventArgs e)
        {
            if (this.Text == "Delete Employee Details")
            {
                txtFname.Enabled = false;
                txtMname.Enabled = false;
                txtLname.Enabled = false;
                txtEmpID.Enabled = false;
                txtPassword.Enabled = false;
                txtDepartment.Enabled = false;
                txtAddress.Enabled = false;
                txtDob.Enabled = false;
                txtPhone.Enabled = false;
                txtMobile.Enabled = false;
                txtSex.Enabled = false;
                txtEducation.Enabled = false;
                txtDesignation.Enabled = false;
                txtEmail.Enabled = false;
                txtDoj.Enabled = false;
            }
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


                    txtFname.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["FName"].ToString();
                    txtMname.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["MName"].ToString();
                    txtLname.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["LName"].ToString();
                    txtEmpID.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["EmpID"].ToString();
                    txtPassword.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Password"].ToString();
                    txtDepartment.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Department"].ToString();
                    txtAddress.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Address"].ToString();
                    txtPhone.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Phone"].ToString();
                    txtMobile.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Mobile"].ToString();
                    txtDob.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Dob"].ToString();
                    txtSex.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Sex"].ToString();
                    txtEducation.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Education"].ToString();
                    txtDesignation.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Designation"].ToString();
                    txtEmail.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Email"].ToString();
                    txtDoj.Text = myDataSet.Tables["EmployeeDetails"].Rows[0]["Doj"].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {


            string str = cbEmpID.Text;

            if (str == "")
            {
                MessageBox.Show("You must select a Employee ID");
            }
            else
            {
                if (txtEmpID.Text != "HR001")
                {
                    try
                    {
                        SqlCommand objUpdate = con.CreateCommand();
                        objUpdate.CommandText = "update EmployeeDetails set EmployeeDetails.[EmpID]='" + txtEmpID.Text + "',EmployeeDetails.[FName]='" + txtFname.Text + "',EmployeeDetails.[MName]='" + txtMname.Text + "',EmployeeDetails.[LName]='" + txtLname.Text + "',EmployeeDetails.[Password]='" + txtPassword.Text + "',EmployeeDetails.[Department]='" + txtDepartment.Text + "',EmployeeDetails.[Address]='" + txtAddress.Text + "',EmployeeDetails.[Phone]='" + txtPhone.Text + "',EmployeeDetails.[Mobile]='" + txtMobile.Text + "',EmployeeDetails.[Sex]='" + txtSex.Text + "',EmployeeDetails.[Education]='" + txtEducation.Text + "',EmployeeDetails.[Designation]='" + txtDesignation.Text + "',EmployeeDetails.[Email]='" + txtEmail.Text + "',EmployeeDetails.[Doj]='" + txtDoj.Text + "',EmployeeDetails.[status]='" + "Inactive" + "' WHERE EmployeeDetails.[EmpID]='" + str + "'";
                        objUpdate.Connection = con;
                        objUpdate.Transaction = objTran;
                        int res = objUpdate.ExecuteNonQuery();
                        if (res >= 1)
                        {
                            MessageBox.Show("Employee's information is deleted from Current Employees data");
                        }
                        cbEmpID.Text = "";
                        txtFname.Text = "";
                        txtMname.Text = "";
                        txtLname.Text = "";
                        txtEmpID.Text = "";
                        txtDob.Text = "";
                        txtAddress.Text = "";
                        txtDepartment.SelectedIndex = -1;
                        txtDesignation.SelectedIndex = -1;
                        txtDoj.Text = "";
                        txtEducation.Text = "";
                        txtEmail.Text = "";
                        txtMobile.Text = "";
                        txtPassword.Text = "";
                        txtSex.SelectedIndex = -1;
                        txtPhone.Text = "";
                        cbEmpID.Items.Clear();
                        string sql;
                        if (GlobalClass.EmpID == "admin")
                        {
                            sql = "SELECT EmpID FROM EmployeeDetails WHERE status IS NULL";
                        }
                        else
                        {
                            sql = "SELECT EmpID FROM EmployeeDetails WHERE EmpID NOT IN('HR001') And status IS NULL";
                        }

                        SqlCommand1 = new SqlCommand(sql, con);
                        SqlDataReader dr = SqlCommand1.ExecuteReader();
                        while (dr.Read())
                        {
                            cbEmpID.Items.Add(dr[0]);
                            count++;
                        }

                        dr.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("No matching record is found");
                    }
                }
                else
                {
                    MessageBox.Show("HR001 is Admin Record.\nIt cannot be deleted");
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = cbEmpID.Text;

            if (str == "")
            {
                MessageBox.Show("You must select a Employee ID");
                return;
            }
            if (txtFname.Text == "")
            {
                MessageBox.Show("Please Enter Name");
                return;
            }
            if (txtEmpID.Text == "")
            {
                MessageBox.Show("Please Enter Employee ID");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                return;
            }
            if (txtDepartment.Text == "")
            {
                MessageBox.Show("Please Selct the Department");
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address");
                return;
            }
            if (txtPhone.Text != "")
            {
                int i = 0;
                string str2 = txtPhone.Text.ToString();
                foreach (char c in str2)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("You cannot enter characters in Phone Number");
                        txtPhone.Text = "";
                        return;
                    }

                    i = i + 1;
                    if (i > 10)
                    {
                        MessageBox.Show("Phone number is not in proper format");
                        txtPhone.Text = "";
                        return;
                    }

                }
            }
            if (txtMobile.Text != "")
            {
                int i = 0;
                string str2 = txtMobile.Text.ToString();
                foreach (char c in str2)
                {
                    if (Char.IsLetter(c))
                    {
                        MessageBox.Show("You cannot enter characters in Cell Number");
                        txtMobile.Text = "";
                        return;
                    }
                    i = i + 1;
                    if (i > 10)
                    {
                        MessageBox.Show("Mobile number is not in proper format");
                        txtMobile.Text = "";
                        return;
                    }
                }
            }
            if (txtSex.Text == "")
            {
                MessageBox.Show("Please Select Sex");
                return;
            }
            if (txtEducation.Text == "")
            {
                MessageBox.Show("Please Enter Education");
                return;
            }
            if (txtDesignation.Text == "")
            {
                MessageBox.Show("Please select Designation");
                return;
            }
            if (Convert.ToDateTime(txtDoj.Text) <= Convert.ToDateTime(txtDob.Text))
            {
                MessageBox.Show("Date of Joining must be greater than Date of Birth. Please Check!!!");
                return;
            }
            else
            {
                if (txtEmail.Text != "")
                {
                    bool validval1 = false, validval2 = false;
                    string str2 = txtEmail.Text.ToString();
                    foreach (char c in str2)
                    {
                        if (c == '@')
                        {
                            validval1 = true;
                            break;
                        }
                    }
                    foreach (char c in str2)
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
                        txtEmail.Text = "";
                        return;
                    }

                }
                try
                {
                    SqlCommand objUpdate = con.CreateCommand();

                    objUpdate.CommandText = "update EmployeeDetails set EmployeeDetails.[EmpID]='" + txtEmpID.Text + "',EmployeeDetails.[FName]='" + txtFname.Text + "',EmployeeDetails.[MName]='" + txtMname.Text + "',EmployeeDetails.[LName]='" + txtLname.Text + "',EmployeeDetails.[Password]='" + txtPassword.Text + "',EmployeeDetails.[Department]='" + txtDepartment.Text + "',EmployeeDetails.[Address]='" + txtAddress.Text + "',EmployeeDetails.[Phone]='" + txtPhone.Text + "',EmployeeDetails.[Mobile]='" + txtMobile.Text + "',EmployeeDetails.[Dob]='" + txtDob.Text + "',EmployeeDetails.[Sex]='" + txtSex.Text + "',EmployeeDetails.[Education]='" + txtEducation.Text + "',EmployeeDetails.[Designation]='" + txtDesignation.Text + "',EmployeeDetails.[Email]='" + txtEmail.Text + "',EmployeeDetails.[Doj]='" + txtDoj.Text + "',EmployeeDetails.[status]=NULL WHERE EmployeeDetails.[EmpID]='" + str + "'";
                    objUpdate.Connection = con;
                    objUpdate.Transaction = objTran;
                    int res = objUpdate.ExecuteNonQuery();
                    if (res >= 1)
                    {
                        MessageBox.Show("Employee's information is updated.");
                    }
                    cbEmpID.Text = "";
                    txtFname.Text = "";
                    txtMname.Text = "";
                    txtLname.Text = "";
                    txtEmpID.Text = "";
                    txtAddress.Text = "";
                    txtDob.Text = "";
                    txtDepartment.SelectedIndex = -1;
                    txtDesignation.SelectedIndex = -1;
                    txtDoj.Text = "";
                    txtEducation.Text = "";
                    txtEmail.Text = "";
                    txtMobile.Text = "";
                    txtPassword.Text = "";
                    txtSex.SelectedIndex = -1;
                    txtPhone.Text = "";
                    cbEmpID.Items.Clear();
                    string sql;
                    if (GlobalClass.EmpID == "admin")
                    {
                        sql = "SELECT EmpID FROM EmployeeDetails WHERE status IS NULL";
                    }
                    else
                    {
                        sql = "SELECT EmpID FROM EmployeeDetails WHERE EmpID NOT IN('HR001') And status IS NULL";
                    }

                    SqlCommand1 = new SqlCommand(sql, con);
                    SqlDataReader dr = SqlCommand1.ExecuteReader();
                    while (dr.Read())
                    {
                        cbEmpID.Items.Add(dr[0]);
                        count++;
                    }

                    dr.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("No matching record is found", "Profile Updation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.Close();
            RestoreEmployeeDetails res = new RestoreEmployeeDetails();


            res.ShowDialog();
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            if (GlobalClass.EmpID != "admin")
            {
                if (txtEmpID.Text == "HR001")
                {
                    MessageBox.Show("This is Admin ID. Please Choose another ID");
                    txtEmpID.Text = "";
                }
            }
            else
            {
                if (cbEmpID.Text != "HR001" && txtEmpID.Text == "HR001")
                {
                    MessageBox.Show("This is Admin ID. Please Choose another ID");
                    txtEmpID.Text = "";
                }
            }
        }

       

    }
}
