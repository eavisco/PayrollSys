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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }
        string sql;
        string rdo;
        private void btnempsave_Click(object sender, EventArgs e)
        {
            //TODO : fix this, not inputting correctly or maybe due to no database to hold data

            if (txtcode.Text == "" || txtfname.Text == "" || txtlname.Text == "" || txtmname.Text == ""
                || txtaddress.Text == "" || txtcontact.Text == "" || txtstatus.Text == "" || txtbplace.Text == ""
                || txtage.Text == "" || txtemerg.Text == "" || txtdrate.Text == "" || txtposition.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (rdomale.Checked)
                {
                    rdo = "Male";
                }
                else
                {
                    rdo = "Female";
                }
                sql = "INSERT INTO 'empdata' ('empID', 'empName', 'empCon', 'empStat', 'emp)" + "VALUES()";
            }
        }

        private void btnempnew_Click(object sender, EventArgs e)
        {

        }
    }
}
