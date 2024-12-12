using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PayrollSys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //TODO: If button click sql connection initialize
        private void button1_Click(object sender, EventArgs e)
        {
            string SQLConnectkana = "server = 127.0.0.1; user=root; database=payrollsysdb; password="; // gumawa ng bago string na ang laman ay location and permission ng database
            MySqlConnection mySqlConnection = new MySqlConnection(SQLConnectkana);
            string username = txtuser.Text.ToString();
            string password = txtpass.Text.ToString();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("no empty fields allowed");
            }
            else
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("select * from emplog", mySqlConnection); // Command para maaccess ang users na table sa sql
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (username.Equals(reader.GetString("empName")) && password.Equals(reader.GetString("empPass")))
                    {
                        Form1 mainForm = new Form1();
                        dashboard dashboardForm = new dashboard();
                        this.Hide();
                        mainForm.FormClosed += (s, args) => this.Close();
                        dashboardForm.Show();
                    }
                    else
                    {
                        
                    }
                }
                mySqlConnection.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
