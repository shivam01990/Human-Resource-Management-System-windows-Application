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
    public partial class Login : Form
    {
        SqlConnection con;
        int i;
        public Login()
        {
            InitializeComponent();
            /*This code will connect HumanResourceManagementSystem project with HRMS database, created in Microsoft SQL Server 2005 having SQL authentication.
           User has to change this connection code as per his compuer node.*/
            //GlobalClass.hostIP = "KOGENT-9800196C";
            //GlobalClass.conn = ("Data Source=" + GlobalClass.hostIP + ";Initial Catalog=HRMS;User ID=sa;Password=kogent");  
            GlobalClass.hostIP = ".";
            GlobalClass.conn = ("Data Source=" + GlobalClass.hostIP + ";Initial Catalog=HRMS;User ID=sa;Password=");  
            
        }
        protected override void OnClosing(CancelEventArgs e)
        {

            Application.Exit();
            base.OnClosing(e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login_ID.Text == "")
            {
                MessageBox.Show("Please Enter the User ID");
                return;
            }
            if (Password.Text == "")
            {
                MessageBox.Show("The Password is Not Valid");
                return;
            }






            try
            {
                con = new SqlConnection(GlobalClass.conn);
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("Select * from  EmployeeDetails", con);
                DataSet ds = new DataSet();
                adp.Fill(ds, "EmployeeDetails");

                if (ds.Tables.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        if ((dr["EmpID"].ToString() == Login_ID.Text) && (dr["Password"].ToString() == Password.Text) && (dr["Department"].ToString() == "HR"))
                        {

                            i = 1;
                            break;
                        }

                        else
                        {
                            continue;
                        }
                    }

                }
                if (i == 1)
                {
                    if (Login_ID.Text == "HR001")
                    {
                        GlobalClass.EmpID = "admin";
                    }
                    HRDepartment hrd = new HRDepartment();
                    GlobalClass.hrd = hrd;
                    GlobalClass.hrd.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Provided information do not match with database.\nPlease check your data");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Provided information do not match with database.\nPlease check your data");
            }
        }






    }
}
