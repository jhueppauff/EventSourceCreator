//-----------------------------------------------------------------------
// <copyright file="EventSourceCreator.cs" company="None">
// Copyright 2017 Jhueppauff
// MIT  
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
//-----------------------------------------------------------------------

namespace EventSourceCreator
{
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;

    /// <summary>
    /// Form Handler, Event Source Creator
    /// </summary>
    public partial class EventSourceCreator : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventSourceCreator"/> class.
        /// </summary>
        public EventSourceCreator()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components != null)
                {
                    this.components.Dispose();
                    GC.SuppressFinalize(this);
                }
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// On Load Event
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">eventargs e</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (EventLog eventLog in EventLog.GetEventLogs())
            {
                try
                {
                    string logName = eventLog.LogDisplayName;
                    this.cbxEventLogName.Items.Add(logName);
                    this.cbxRemEventLogName.Items.Add(logName);
                }
                catch (System.Security.SecurityException ex)
                {
                    // Does not have permissions to read log
                    this.tbxStatus.Text += ex.Message + Environment.NewLine;
                }
            }
        }

        /// <summary>
        /// CreateEventSource_Click, Creates the Event Source
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">EventArgs e</param>
        private void Btn_Create_EventSource_Click(object sender, EventArgs e)
        {
            try
            {
                if (EventLog.SourceExists(this.tbxEventSourceName.Text))
                {
                    EventLog.CreateEventSource(this.tbxEventSourceName.Text, this.cbxEventLogName.SelectedItem.ToString());
                }
            }
            catch (System.Security.SecurityException ex)
            {
                this.tbxStatus.Text += ex.Message + Environment.NewLine;
            }
        }

        /// <summary>
        /// DeleteSource_Click, Delete Event Source
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">EventArgs e</param>
        private void Btn_DeleteSource_Click(object sender, EventArgs e)
        {
            try
            {
                if (EventLog.SourceExists(this.tbxRemEventSourceName.Text))
                {
                    EventLog.DeleteEventSource(this.tbxRemEventSourceName.Text);
                }
                else
                {
                    this.tbxStatus.Text += "Source does not exist" + Environment.NewLine;
                }
            }
            catch (System.Security.SecurityException ex)
            {
                this.tbxStatus.Text += ex.Message + Environment.NewLine;
            }
        }
    }
}