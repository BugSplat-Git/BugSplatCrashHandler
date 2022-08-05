using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;
using BugSplatDotNetStandard;
using System.Diagnostics;

namespace BugSplatCrashHandler
{
    public partial class CrashDialogForm : Form
    {
        // State variables describing the crash to upload
        string database = "";
        string application = "";
        string version = "";
        string notes = "";
        string logFilePath = "";
        FileInfo minidumpPath;
        MinidumpPostOptions options = new MinidumpPostOptions();
        
        RegistryKey userCredsKey = null;
        const string USER_CREDS_REGISTRY_KEY_PATH = "Software\\BugSplat\\UserCredentials";
        const string USER_NAME_REGISTRY_KEY = "UserName";
        const string USER_EMAIL_REGISTRY_KEY = "UserEmail";

        public CrashDialogForm()
        {
            InitializeComponent();
            InitializeOptions();
        }

        private void InitializeOptions()
        {
            // User entered credentials saved here
            userCredsKey = Registry.CurrentUser.CreateSubKey(USER_CREDS_REGISTRY_KEY_PATH);

            // Allow either Database or Vendor (legacy) for database property
            database = Program.CrashIni.Read("Database");
            database = string.IsNullOrEmpty(database) ? Program.CrashIni.Read("Vendor") : database;
            if (string.IsNullOrEmpty(database))
            {
                MessageBox.Show("No database property found!", "Error");
                Environment.Exit(1);
            }

            application = Program.CrashIni.Read("Application", true);
            version = Program.CrashIni.Read("Version", true);

            var crashType = Program.CrashIni.Read("CrashType", true);
            options.MinidumpType = StringToMinidumpTypeId(crashType);

            var minidump = Program.CrashIni.Read("MiniDump", true);
            minidumpPath = new FileInfo(minidump);

            // ToDo: We need API support for the Notes field
            notes = Program.CrashIni.Read("Notes", false);

            // Read default user/email from ini
            options.User = Program.CrashIni.Read("User", false);
            options.Email = Program.CrashIni.Read("Email", false);

            // If defaults for user/email are empty, get last user-entered values
            if (options.User.Length == 0)
            {
                var rval = userCredsKey?.GetValue(USER_NAME_REGISTRY_KEY, null);
                options.User = rval?.ToString();
            }

            if (options.Email.Length == 0)
            {
                var rval = userCredsKey?.GetValue(USER_EMAIL_REGISTRY_KEY, null);
                options.Email = rval?.ToString();
            }

            // Update dialog text
            usernameTextBox.Text = options.User;
            emailTextBox.Text = options.Email;

            var userDescription = Program.CrashIni.Read("UserDescription", false);
            options.Description = userDescription;

            // Add each file attachment
            var attachmentNumber = 0;
            logFilePath = Program.CrashIni.Read("LogFilePath", false);
            if (logFilePath.Length > 0)
            {
                attachmentNumber++;
                var logFile = new FileInfo(logFilePath);
                options.Attachments.Add(logFile);
            }

            while (true)
            {
                var fname = Program.CrashIni.Read("AdditionalFile" + attachmentNumber++, false);
                if (fname.Length <= 0)
                {
                    break;
                }
                var item = new FileInfo(fname);
                options.Attachments.Add(item);
            }
        }

        private BugSplat.MinidumpTypeId StringToMinidumpTypeId(string typestr)
        {
            if (typestr.Equals("Windows.Native", StringComparison.OrdinalIgnoreCase))
            {
                return BugSplat.MinidumpTypeId.WindowsNative;
            }
            else if (typestr.Equals("DotNet", StringComparison.OrdinalIgnoreCase))
            {
                return BugSplat.MinidumpTypeId.DotNet;
            }
            else if (typestr.Equals("UnityNativeWindows", StringComparison.OrdinalIgnoreCase))
            {
                return BugSplat.MinidumpTypeId.UnityNativeWindows;
            }

            return BugSplat.MinidumpTypeId.Unknown;
        }

        private void userDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            options.Description = userDescriptionTextBox.Text;
        }

        private async void sendErrorReportButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(minidumpPath?.FullName))
            {
                var bugsplat = new BugSplat(database, application, version);
                await bugsplat.Post(minidumpPath, options);
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
            userCredsKey?.SetValue(USER_EMAIL_REGISTRY_KEY, email);
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text;
            options.User = username;
            userCredsKey?.SetValue(USER_NAME_REGISTRY_KEY, username);
        }

        private void viewReportDetailsButton_Click(object sender, EventArgs e)
        {
            // TODO BG
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
