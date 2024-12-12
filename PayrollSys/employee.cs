using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using PayrollSys.Includes;
using static Org.BouncyCastle.Math.EC.ECCurve;
using MySql.Data.MySqlClient;

namespace PayrollSys
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }
        
        //SQLConfig config = new SQLConfig();
        //usableFunction funct = new usableFunction();
        string sql;
        string rdo;
        private void btnempsave_Click(object sender, EventArgs e)
        {
            //TODO : SQLConfig integration

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
                sql = "INSERT INTO 'empdata'('empID', 'empFirstName', 'empLastName', 'empMiddleName', 'empCon', 'empStat', 'empPlaceb', 'empGen', 'empBirth', 'empAge', 'empEmerg', 'empDailyRate','empPos', 'empHire')" + 
                    "VALUES('" +txtcode.Text + "', '" + txtfname.Text + " ', '" + txtlname.Text + "', '" + txtmname.Text + "', '" + txtcontact.Text + "', '" + txtstatus.Text + "', '" + txtbplace.Text + "', '" + rdo + "', '" + txtbplace.Text + "', '" 
                    + txtage.Text + "', '" + txtemerg.Text + "', '" + txtdrate.Text + "', '" + txtposition.Text + "', '" + txtposition.Text + "')";
               // config.Execute_Query(sql);
            }
        }

        private void btnempnew_Click(object sender, EventArgs e)
        {
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
                }//AYUSIN PA TO FOR UPDATING NEW VALUES
                sql = "UPDATE 'empdata' SET ('empID', 'empFirstName', 'empLastName', 'empMiddleName', 'empCon', 'empStat', 'empPlaceb', 'empGen', 'empBirth', 'empAge', 'empEmerg', 'empDailyRate','empPos', 'empHire')" +
                    "VALUES('" + txtcode.Text + "', '" + txtfname.Text + " ', '" + txtlname.Text + "', '" + txtmname.Text + "', '" + txtcontact.Text + "', '" + txtstatus.Text + "', '" + txtbplace.Text + "', '" + rdo + "', '" + txtbplace.Text + "', '"
                    + txtage.Text + "', '" + txtemerg.Text + "', '" + txtdrate.Text + "', '" + txtposition.Text + "', '" + txtposition.Text + "')";
                //config.Execute_Query(sql);
            }
        }
    }
}
