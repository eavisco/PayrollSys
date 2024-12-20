﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PayrollSys
{
    public partial class reports : Form
    {
        string connectionString = "server = 127.0.0.1; user=root; database=payrollsysdb; password="; //importante to sa lahat para maconnect sa sql

        public static object SpecialFolder { get; internal set; }
        public string dataToReport { get; }

        public reports()
        {
            InitializeComponent();

            richTextBoxReport.Text = dataToReport;
        }

        private void reports_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Printing logic (can be extended with PrintDocument)
                MessageBox.Show("Print functionality not implemented yet.", "Info");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                DefaultExt = "txt",
                FileName = "PayrollReport.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBoxReport.Text);
                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void richTextBoxReport_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxReport_TextChanged_1(object sender, EventArgs e)
        {
            payroll.show();
        }
    }
}

