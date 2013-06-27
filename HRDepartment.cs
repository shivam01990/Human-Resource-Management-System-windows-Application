using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResourceManagementSystem
{
    public partial class HRDepartment : Form
    {
        public HRDepartment()
        {
            InitializeComponent();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {

            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void btnEmpNew_Click(object sender, EventArgs e)
        {


            HRAddNewEmployee hrane = new HRAddNewEmployee();


            hrane.ShowDialog();



        }

        private void btnEmpSearch_Click(object sender, EventArgs e)
        {

            HREmployeeSearch hres = new HREmployeeSearch();



            hres.ShowDialog();

        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {

            HREmployeeDetail hred = new HREmployeeDetail();
            hred.Text = "Update Employee Details";
            hred.AcceptButton = hred.btnUpdate;
            hred.btnDelete.Hide();
            hred.btnRestore.Hide();


            hred.ShowDialog();
        }

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {

            HREmployeeDetail hred = new HREmployeeDetail();
            hred.Text = "Delete Employee Details";
            hred.AcceptButton = hred.btnDelete;
            hred.btnUpdate.Hide();


            hred.ShowDialog();
        }





        private void btnDailyAtt_Click(object sender, EventArgs e)
        {

            AddAttendanceDetails aad = new AddAttendanceDetails();



            aad.ShowDialog();
        }

        private void btnAttReport_Click(object sender, EventArgs e)
        {

            ViewAttendanceReport var = new ViewAttendanceReport();

            var.ShowDialog();

        }

        private void btnLeaveRequest_Click(object sender, EventArgs e)
        {

            LeaveRequestForm lrf = new LeaveRequestForm();



            lrf.ShowDialog();

        }

        private void btnViewAllLeaveRequests_Click(object sender, EventArgs e)
        {

            ViewLeaveRequest vlr = new ViewLeaveRequest();

            vlr.ShowDialog();
        }

        private void btnSearchAttendance_Click(object sender, EventArgs e)
        {

            AttendanceDetails sad = new AttendanceDetails();

            sad.ShowDialog();
        }

        private void btnEmployeeAgreement_Click(object sender, EventArgs e)
        {

            EmployeeSalaryAgreement esa = new EmployeeSalaryAgreement();
            esa.ShowDialog();

        }

        private void btnCalcSalary_Click(object sender, EventArgs e)
        {

            CalcSalary esa = new CalcSalary();
            esa.ShowDialog();
        }

        private void btnSlipOrReport_Click(object sender, EventArgs e)
        {

            SalarySlip esa = new SalarySlip();
            esa.ShowDialog();
        }

        private void btnSalReport_Click(object sender, EventArgs e)
        {
            SearchSalaryDetails ssd = new SearchSalaryDetails();
            ssd.ShowDialog();
        }

      
       
       
        
    }
}
