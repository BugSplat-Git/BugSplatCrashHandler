using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;
using BugSplatDotNetStandard;
using System.Diagnostics;
using System.Collections.Generic;

namespace BugSplatCrashHandler
{
    public partial class CrashDialogForm : Form
    {
        BugSplat bugsplat;
        MinidumpPostOptions options;
        FileInfo crashReportFile;
        RegistryKey userCredsKey;


        public CrashDialogForm(BugSplat bugsplat, FileInfo crashReportFile, MinidumpPostOptions options)
        {
            this.bugsplat = bugsplat;
            this.crashReportFile = crashReportFile;
            this.options = options;
            InitializeComponent();
            InitializeOptions();
        }

        private void InitializeOptions()
        {
            // User entered credentials saved here
            userCredsKey = Registry.CurrentUser.CreateSubKey(Program.USER_CREDS_REGISTRY_KEY_PATH);

            // Update dialog text
            usernameTextBox.Text = options.User;
            emailTextBox.Text = options.Email;
            userDescriptionTextBox.Text = options.Description;
        }

        private void userDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            options.Description = userDescriptionTextBox.Text;
        }

        private void sendErrorReportButton_Click(object sender, EventArgs e)
        {
            sendErrorReportButton.Enabled = false;

            if (File.Exists(crashReportFile?.FullName))
            {
                var poster = new CrashPoster(bugsplat);
                poster.PostCrashAndDisplaySupportResponseIfAvailable(crashReportFile, options);
            }

            Application.Exit();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            var email = emailTextBox.Text;
            options.Email = email;
            userCredsKey?.SetValue(Program.USER_EMAIL_REGISTRY_KEY, email);
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text;
            options.User = username;
            userCredsKey?.SetValue(Program.USER_NAME_REGISTRY_KEY, username);
        }

        private void viewReportDetailsButton_Click(object sender, EventArgs e)
        {
            var files = new List<FileInfo>();
            files.Add(crashReportFile);
            files.AddRange(options.Attachments);
            new ReportDetailsForm(files).ShowDialog();
        }

        private void poweredByBugSplatLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process browser = new Process())
            {
                browser.StartInfo.FileName = "https://www.bugsplat.com";
                browser.StartInfo.Arguments = null;
                browser.StartInfo.UseShellExecute = true;
                browser.Start();
            }
        }
    }
}
