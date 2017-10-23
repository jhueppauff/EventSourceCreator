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
    /// <summary>
    /// Event Source Creator Designer
    /// </summary>
    public partial class EventSourceCreator
    {
        /// <summary>
        /// Button Create EventSource
        /// </summary>
        private System.Windows.Forms.Button btnCreateEventSource;

        /// <summary>
        /// Text Box Event Source Name
        /// </summary>
        private System.Windows.Forms.TextBox tbxEventSourceName;

        /// <summary>
        /// Group Box 1
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;

        /// <summary>
        /// Label 2
        /// </summary>
        private System.Windows.Forms.Label label2;

        /// <summary>
        /// Label 1
        /// </summary>
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// ComboBox Event Log Name
        /// </summary>
        private System.Windows.Forms.ComboBox cbxEventLogName;

        /// <summary>
        /// Text Box Status
        /// </summary>
        private System.Windows.Forms.TextBox tbxStatus;

        /// <summary>
        /// Group Box 2
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox2;

        /// <summary>
        /// Button Delete Source
        /// </summary>
        private System.Windows.Forms.Button btnDeleteSource;

        /// <summary>
        /// Combo Box Remove Event Log Name
        /// </summary>
        private System.Windows.Forms.ComboBox cbxRemEventLogName;

        /// <summary>
        /// Label 4
        /// </summary>
        private System.Windows.Forms.Label label4;

        /// <summary>
        /// Label 3
        /// </summary>
        private System.Windows.Forms.Label label3;

        /// <summary>
        /// Text Box Remove Event Source Name
        /// </summary>
        private System.Windows.Forms.TextBox tbxRemEventSourceName;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateEventSource = new System.Windows.Forms.Button();
            this.tbxEventSourceName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEventLogName = new System.Windows.Forms.ComboBox();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxRemEventSourceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteSource = new System.Windows.Forms.Button();
            this.cbxRemEventLogName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateEventSource
            // 
            this.btnCreateEventSource.Location = new System.Drawing.Point(301, 114);
            this.btnCreateEventSource.Name = "btnCreateEventSource";
            this.btnCreateEventSource.Size = new System.Drawing.Size(123, 30);
            this.btnCreateEventSource.TabIndex = 0;
            this.btnCreateEventSource.Text = "Create";
            this.btnCreateEventSource.UseVisualStyleBackColor = true;
            this.btnCreateEventSource.Click += new System.EventHandler(this.Btn_Create_EventSource_Click);
            // 
            // tbxEventSourceName
            // 
            this.tbxEventSourceName.Location = new System.Drawing.Point(6, 54);
            this.tbxEventSourceName.Name = "tbxEventSourceName";
            this.tbxEventSourceName.Size = new System.Drawing.Size(404, 26);
            this.tbxEventSourceName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxEventLogName);
            this.groupBox1.Controls.Add(this.tbxEventSourceName);
            this.groupBox1.Controls.Add(this.btnCreateEventSource);
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
            // cbxEventLogName
            // 
            this.cbxEventLogName.FormattingEnabled = true;
            this.cbxEventLogName.Location = new System.Drawing.Point(6, 114);
            this.cbxEventLogName.Name = "cbxEventLogName";
            this.cbxEventLogName.Size = new System.Drawing.Size(275, 28);
            this.cbxEventLogName.TabIndex = 3;
            // 
            // tbxStatus
            // 
            this.tbxStatus.Location = new System.Drawing.Point(12, 213);
            this.tbxStatus.Multiline = true;
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.ReadOnly = true;
            this.tbxStatus.Size = new System.Drawing.Size(958, 214);
            this.tbxStatus.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxRemEventSourceName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDeleteSource);
            this.groupBox2.Controls.Add(this.cbxRemEventLogName);
            this.groupBox2.Location = new System.Drawing.Point(471, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Event Source";
            // 
            // tbxRemEventSourceName
            // 
            this.tbxRemEventSourceName.Location = new System.Drawing.Point(10, 118);
            this.tbxRemEventSourceName.Name = "tbxRemEventSourceName";
            this.tbxRemEventSourceName.Size = new System.Drawing.Size(396, 26);
            this.tbxRemEventSourceName.TabIndex = 5;
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
            // btnDeleteSource
            // 
            this.btnDeleteSource.Location = new System.Drawing.Point(412, 115);
            this.btnDeleteSource.Name = "btnDeleteSource";
            this.btnDeleteSource.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteSource.TabIndex = 2;
            this.btnDeleteSource.Text = "Delete";
            this.btnDeleteSource.UseVisualStyleBackColor = true;
            this.btnDeleteSource.Click += new System.EventHandler(this.Btn_DeleteSource_Click);
            // 
            // cbxRemEventLogName
            // 
            this.cbxRemEventLogName.FormattingEnabled = true;
            this.cbxRemEventLogName.Location = new System.Drawing.Point(10, 52);
            this.cbxRemEventLogName.Name = "cbxRemEventLogName";
            this.cbxRemEventLogName.Size = new System.Drawing.Size(483, 28);
            this.cbxRemEventLogName.TabIndex = 0;
            // 
            // EventSourceCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbxStatus);
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
    }
}