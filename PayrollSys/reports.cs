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
    public partial class reports : Form
    {
        string connectionString = "server = 127.0.0.1; user=root; database=payrollsysdb; password="; //importante to sa lahat para maconnect sa sql
        public reports()
        {
            InitializeComponent();
        }

        private void reports_Load(object sender, EventArgs e)
        {

        }
    }
}
