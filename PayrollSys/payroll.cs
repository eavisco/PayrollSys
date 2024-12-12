﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSys
{
    public partial class payroll : Form
    {
        string connectionString = "server = 127.0.0.1; user=root; database=payrollsysdb; password=";


        public payroll()
        {
            InitializeComponent();
            InitializeEmployeeIds();
        }
        private void InitializeEmployeeIds()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT empID FROM empdata";

                    using (var cmd = new MySqlCommand(query, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            domainUpDown1.Items.Add(reader["empID"].ToString());
                        }
                    }
                }

                domainUpDown1.SelectedIndex = 0; // Default selection
                UpdateEmployeeName();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee IDs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            UpdateEmployeeName();
        }

        private void UpdateEmployeeName()
        {
            try
            {
                string employeeId = domainUpDown1.SelectedItem?.ToString() ?? ""; // Ensure correct assignment
                if (string.IsNullOrEmpty(employeeId)) return;

                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT empLastName, empFirstName, empMiddleName FROM empdata WHERE empID = @empID";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@empID", employeeId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string lastName = reader["empLastName"].ToString();
                                string firstName = reader["empFirstName"].ToString();
                                string middleName = reader["empMiddleName"].ToString();
                                label20.Text = $"{lastName}, {firstName} {middleName}"; // Use label instead of TextBox
                            }
                            else
                            {
                                label20.Text = "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeId = domainUpDown1.Text;
                string query = @"INSERT INTO emppay (pay, workDay, payRate, rateWage, overtimeHour, overtimeRegular, holidayDaily, holidayPay, grossInc, netInc, deducPagibig, deducPhillhealth, deducSSS) 
                                 VALUES (@pay, @workDay, @payRate, @rateWage, @overtimeHour, @overtimeRegular, @holidayDaily, @holidayPay, @grossInc, @netInc, @deducPagibig, @deducPhillhealth, @deducSSS)";

                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pay", textBox1.Text);
                        cmd.Parameters.AddWithValue("@workDay", textBox3.Text);
                        cmd.Parameters.AddWithValue("@payRate", textBox2.Text);
                        cmd.Parameters.AddWithValue("@rateWage", textBox4.Text);
                        cmd.Parameters.AddWithValue("@overtimeHour", textBox5.Text);
                        cmd.Parameters.AddWithValue("@overtimeRegular", textBox7.Text);
                        cmd.Parameters.AddWithValue("@holidayDaily", textBox6.Text);
                        cmd.Parameters.AddWithValue("@holidayPay", textBox8.Text);
                        cmd.Parameters.AddWithValue("@grossInc", textBox9.Text);
                        cmd.Parameters.AddWithValue("@netInc", textBox10.Text);
                        cmd.Parameters.AddWithValue("@deducPagibig", textBox12.Text);
                        cmd.Parameters.AddWithValue("@deducPhillhealth", textBox13.Text);
                        cmd.Parameters.AddWithValue("@deducSSS", textBox14.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Payment data saved successfully for Employee ID: {employeeId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving payment data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            domainUpDown1.SelectedIndex = 0;
            label20.Text = "";
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
        }
    }
}
