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
        public dashboard()
        {
            InitializeComponent();
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
            employee employeeForm = new employee();
            employeeForm.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
