﻿namespace PayrollSys
{
    partial class attendance
    {

        
            
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empcode = new System.Windows.Forms.DomainUpDown();
            this.timein = new System.Windows.Forms.DateTimePicker();
            this.timeout = new System.Windows.Forms.DateTimePicker();
            this.empdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // empcode
            // 
            this.empcode.Location = new System.Drawing.Point(124, 50);
            this.empcode.Name = "empcode";
            this.empcode.Size = new System.Drawing.Size(200, 20);
            this.empcode.TabIndex = 4;
            // 
            // timein
            // 
            this.timein.Location = new System.Drawing.Point(330, 50);
            this.timein.Name = "timein";
            this.timein.Size = new System.Drawing.Size(200, 20);
            this.timein.TabIndex = 5;
            // 
            // timeout
            // 
            this.timeout.Location = new System.Drawing.Point(536, 50);
            this.timeout.Name = "timeout";
            this.timeout.Size = new System.Drawing.Size(200, 20);
            this.timeout.TabIndex = 6;
            // 
            // empdate
            // 
            this.empdate.Location = new System.Drawing.Point(124, 127);
            this.empdate.Name = "empdate";
            this.empdate.Size = new System.Drawing.Size(200, 20);
            this.empdate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "LOG ATTENDANCE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.empdate);
            this.Controls.Add(this.timeout);
            this.Controls.Add(this.timein);
            this.Controls.Add(this.empcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "attendance";
            this.Text = "attendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown empcode;
        private System.Windows.Forms.DateTimePicker timein;
        private System.Windows.Forms.DateTimePicker timeout;
        private System.Windows.Forms.DateTimePicker empdate;
        private System.Windows.Forms.Button button1;
    }
}