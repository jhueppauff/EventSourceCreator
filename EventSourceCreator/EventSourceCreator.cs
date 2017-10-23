﻿//-----------------------------------------------------------------------
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
    using System.Windows.Forms;
    using System.Diagnostics;

    public partial class EventSourceCreator : Form
    {
        public EventSourceCreator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (EventLog eventLog in EventLog.GetEventLogs())
            {
                try
                {
                    string logName = eventLog.LogDisplayName;
                    cbx_event_log_name.Items.Add(logName);
                    cbx_rem_eventlogname.Items.Add(logName);
                }
                catch (System.Security.SecurityException ex)
                {
                    // Does not have permissions to read log
                    tbx_status.Text += ex.Message + Environment.NewLine;
                }
            }
        }

        private void btn_create_eventsource_Click(object sender, EventArgs e)
        {
            try
            {
                if (EventLog.SourceExists(tbx_eventsource_name.Text))
                {
                    EventLog.CreateEventSource(tbx_eventsource_name.Text, cbx_event_log_name.SelectedItem.ToString());
                }
            }
            catch (System.Security.SecurityException ex)
            {
                tbx_status.Text += ex.Message + Environment.NewLine;
            }
        }

        private void btn_deletesource_Click(object sender, EventArgs e)
        {
            try
            {
                if (EventLog.SourceExists(tbx_rem_eventsourcename.Text))
                {
                    EventLog.DeleteEventSource(tbx_rem_eventsourcename.Text);
                }
                else
                {
                    tbx_status.Text += "Source does not exist" + Environment.NewLine;
                }
            }
            catch (System.Security.SecurityException ex)
            {
                tbx_status.Text += ex.Message + Environment.NewLine;
            }
        }
    }
}
