using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSys
{
    public partial class dashboard : Form
    {
        private bool isAdmin;

        public bool IsAdmin
        {
            get { return isAdmin; }
            set
            {
                isAdmin = value;
                UpdateButtonStates();
            }
        }

        public dashboard()
        {
            InitializeComponent();
        }

        private void UpdateButtonStates()
        {
            // Enable/disable buttons based on whether the user is an admin or employee
            if (isAdmin)
            {
                // Admin: Enable payroll and attendance buttons, leave emp button enabled
                btnpayroll.Enabled = true;  // Enable payroll for admin
                btnattendance.Enabled = true;  // Enable attendance for admin
                btnemp.Enabled = true;  // Enable employee button for admin (admin can manage employees)

                // Optionally reset button colors (no grey out for admin)
                btnpayroll.BackColor = SystemColors.Control;
                btnattendance.BackColor = SystemColors.Control;
                btnemp.BackColor = SystemColors.Control;
            }
            else
            {
                // Employee: Disable employee button and enable the rest
                btnpayroll.Enabled = true;  // Enable payroll for employee
                btnattendance.Enabled = true;  // Enable attendance for employee
                btnemp.Enabled = false;  // Disable employee button for employee (employees can't manage other employees)

                // Optionally grey out the employee button for employees
                btnpayroll.BackColor = SystemColors.Control;
                btnattendance.BackColor = SystemColors.Control;
                btnemp.BackColor = Color.Gray;  // Grey out employee button for employees
            }
        }

        private void btnpayroll_Click(object sender, EventArgs e)
        {
            payroll payrollForm = new payroll();
            payrollForm.Show();
        }

        private void btnattendance_Click(object sender, EventArgs e)
        {
            attendance attendanceForm = new attendance();
            attendanceForm.Show();
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            // Open the employee form only if the button is enabled
            if (btnemp.Enabled)
            {
                employee employeeForm = new employee();
                employeeForm.Show();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            // Hide the current dashboard form
            this.Hide();

            // Create a new instance of the login form (Form1) and show it
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
    }

}
