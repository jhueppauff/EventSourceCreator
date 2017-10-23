//-----------------------------------------------------------------------
// <copyright file="EventSourceCreator.Designer.cs" company="None">
// Copyright 2017 Jhueppauff
// MIT  
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
//-----------------------------------------------------------------------

namespace EventSourceCreator
{
    partial class EventSourceCreator
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
            this.btn_create_eventsource = new System.Windows.Forms.Button();
            this.tbx_eventsource_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_event_log_name = new System.Windows.Forms.ComboBox();
            this.tbx_status = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_deletesource = new System.Windows.Forms.Button();
            this.cbx_rem_eventlogname = new System.Windows.Forms.ComboBox();
            this.tbx_rem_eventsourcename = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_create_eventsource
            // 
            this.btn_create_eventsource.Location = new System.Drawing.Point(301, 114);
            this.btn_create_eventsource.Name = "btn_create_eventsource";
            this.btn_create_eventsource.Size = new System.Drawing.Size(123, 30);
            this.btn_create_eventsource.TabIndex = 0;
            this.btn_create_eventsource.Text = "Create";
            this.btn_create_eventsource.UseVisualStyleBackColor = true;
            this.btn_create_eventsource.Click += new System.EventHandler(this.btn_create_eventsource_Click);
            // 
            // tbx_eventsource_name
            // 
            this.tbx_eventsource_name.Location = new System.Drawing.Point(6, 54);
            this.tbx_eventsource_name.Name = "tbx_eventsource_name";
            this.tbx_eventsource_name.Size = new System.Drawing.Size(404, 26);
            this.tbx_eventsource_name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_event_log_name);
            this.groupBox1.Controls.Add(this.tbx_eventsource_name);
            this.groupBox1.Controls.Add(this.btn_create_eventsource);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create EventSource";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Log Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Event Source Name:";
            // 
            // cbx_event_log_name
            // 
            this.cbx_event_log_name.FormattingEnabled = true;
            this.cbx_event_log_name.Location = new System.Drawing.Point(6, 114);
            this.cbx_event_log_name.Name = "cbx_event_log_name";
            this.cbx_event_log_name.Size = new System.Drawing.Size(275, 28);
            this.cbx_event_log_name.TabIndex = 3;
            // 
            // tbx_status
            // 
            this.tbx_status.Location = new System.Drawing.Point(12, 213);
            this.tbx_status.Multiline = true;
            this.tbx_status.Name = "tbx_status";
            this.tbx_status.ReadOnly = true;
            this.tbx_status.Size = new System.Drawing.Size(958, 214);
            this.tbx_status.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_rem_eventsourcename);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_deletesource);
            this.groupBox2.Controls.Add(this.cbx_rem_eventlogname);
            this.groupBox2.Location = new System.Drawing.Point(471, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Event Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Event Source Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Event Log Name";
            // 
            // btn_deletesource
            // 
            this.btn_deletesource.Location = new System.Drawing.Point(412, 115);
            this.btn_deletesource.Name = "btn_deletesource";
            this.btn_deletesource.Size = new System.Drawing.Size(75, 30);
            this.btn_deletesource.TabIndex = 2;
            this.btn_deletesource.Text = "Delete";
            this.btn_deletesource.UseVisualStyleBackColor = true;
            this.btn_deletesource.Click += new System.EventHandler(this.btn_deletesource_Click);
            // 
            // cbx_rem_eventlogname
            // 
            this.cbx_rem_eventlogname.FormattingEnabled = true;
            this.cbx_rem_eventlogname.Location = new System.Drawing.Point(10, 52);
            this.cbx_rem_eventlogname.Name = "cbx_rem_eventlogname";
            this.cbx_rem_eventlogname.Size = new System.Drawing.Size(483, 28);
            this.cbx_rem_eventlogname.TabIndex = 0;
            // 
            // tbx_rem_eventsourcename
            // 
            this.tbx_rem_eventsourcename.Location = new System.Drawing.Point(10, 118);
            this.tbx_rem_eventsourcename.Name = "tbx_rem_eventsourcename";
            this.tbx_rem_eventsourcename.Size = new System.Drawing.Size(396, 26);
            this.tbx_rem_eventsourcename.TabIndex = 5;
            // 
            // EventSourceCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbx_status);
            this.Controls.Add(this.groupBox1);
            this.Name = "EventSourceCreator";
            this.Text = "Event Source Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create_eventsource;
        private System.Windows.Forms.TextBox tbx_eventsource_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_event_log_name;
        private System.Windows.Forms.TextBox tbx_status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_deletesource;
        private System.Windows.Forms.ComboBox cbx_rem_eventlogname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_rem_eventsourcename;
    }
}

