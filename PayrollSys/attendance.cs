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
    public partial class attendance : Form
    {
        
        public attendance()
        {
            InitializeComponent();
            InitializeEmployeeIds();
            InitializeTimePickers();

        }
     
        private void InitializeEmployeeIds()
        {
            // TODO: database integration 
            for (int i = 1; i <= 10; i++)
            {
                empcode.Items.Add(i.ToString("D4"));
            }
            empcode.SelectedIndex = 0;
        }

        private void InitializeTimePickers()
        {
            
            timein.Value = DateTime.Now;
            timeout.Value = DateTime.Now.AddHours(8); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string employeeId = empcode.Text;
                DateTime date = empdate.Value.Date;
                TimeSpan timeIn = timein.Value.TimeOfDay;
                TimeSpan timeOut = timeout.Value.TimeOfDay;

                
                //if (timeOut <= timeIn)
                {
                    MessageBox.Show("Time Out must be after Time In.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // TODO: database integration

                string message = $"Attendance recorded:\nEmployee ID: {employeeId}\nDate: {date.ToShortDateString()}\nTime In: {timeIn.ToString(@"hh\:mm")}\nTime Out: {timeOut.ToString(@"hh\:mm")}";
                MessageBox.Show(message, "Attendance Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                empcode.SelectedIndex = 0;
                timein.Value = DateTime.Now;
                timeout.Value = DateTime.Now.AddHours(8);
            }

            

        }
    }
    }

