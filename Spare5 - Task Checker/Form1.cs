using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;

namespace Spare5___Task_Checker
{
    public partial class Form1 : Form
    {
        //Setup Button State Variable
        bool check = false;
        public Form1()
        {
            InitializeComponent();

            //Setup
            txtURL.Text = "http://app.spare5.com/fives/tasks/512";
            txtPageDelay.Text = "0";
            txtRefreshDelay.Text = "5";
            //Initial Status
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "Status: Stopped";
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Store Delay Times
            int pageDelay, refreshDelay;
            //Convert Text Boxes Delay to Numbers
            int.TryParse(txtPageDelay.Text, out pageDelay);
            int.TryParse(txtRefreshDelay.Text, out refreshDelay);
            //Convert from normal seconds to milliseconds
            pageDelay *= 1000;
            refreshDelay *= 1000;
            //Check Button States
            if (check == false)
            {
                check = true;
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Status: Started";
            }
            else
            {
                check = false;
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Status: Stopped";
            }
            //Loop Until User Wants to Stop
            while (check)
            {
                Application.DoEvents();
                Process.Start("chrome.exe", txtURL.Text);
                string url = "";
                System.Threading.Thread.Sleep(pageDelay);
                foreach (Process process in Process.GetProcessesByName("chrome"))
                {
                    url = GetChromeUrl(process);
                    if (url == null)
                        continue;
                    else
                    {
                        url = "http://" + url;
                        break;
                    }
                }

                if (url == txtURL.Text)
                {
                    System.Media.SystemSounds.Beep.Play();
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Status: Stopped";
                    check = false;
                }
                else
                {
                    //check url bar
                    string urlc = url.Substring(7);
                    if (urlc == "https://app.spare5.com/fives/tasks")
                        SendKeys.Send("^w");
                    System.Threading.Thread.Sleep(refreshDelay);
                }
            }
        }
        string GetChromeUrl(Process process)
        {
            if (process == null)
                throw new ArgumentNullException("process");

            if (process.MainWindowHandle == IntPtr.Zero)
                return null;

            AutomationElement element = AutomationElement.FromHandle(process.MainWindowHandle);
            if (element == null)
                return null;

            AutomationElementCollection edits5 = element.FindAll(TreeScope.Subtree, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));
            AutomationElement edit = edits5[0];
            string vp = ((ValuePattern)edit.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
            return vp;
        }
    }
}
