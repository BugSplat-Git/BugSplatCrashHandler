
using BugSplatDotNetStandard;
using Microsoft.Win32;
using System.Diagnostics;

namespace BugSplatCrashHandler
{
    public partial class CrashReportDialog : Form
    {
        // State variables describing the crash to upload
        string database = "";
        string application = "";
        string version = "";
        FileInfo? minidumpPath; 
        MinidumpPostOptions options = new MinidumpPostOptions();
        string notes = "";
        string logFilePath = "";
        RegistryKey? userCredsKey = null;

        // Registry constants
        const string USER_CREDS = "Software\\BugSplat\\UserCredentials";
        const string USER_NAME = "UserName";
        const string USER_EMAIL = "UserEmail";

        public CrashReportDialog()
        {           
            InitializeComponent();
            InitializeOptions();
        }

        private void InitializeOptions()
        {
            // User entered credentials saved here
            userCredsKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(USER_CREDS);

            // Allow either Database or Vendor (legacy) for database property
            database = Program.crash_ini.Read("Database");
            if (database == "")
            {
                database = Program.crash_ini.Read("Vendor");
                if (database == "")
                {
                    MessageBox.Show("No database property found!");
                    Application.Exit();
                }
            }

            application = Program.crash_ini.Read("Application", true);
            version = Program.crash_ini.Read("Version", true);

            string crashType = Program.crash_ini.Read("CrashType", true);
            options.MinidumpType = stringToMinidumpTypeId(crashType);

            string minidump = Program.crash_ini.Read("MiniDump", true);
            minidumpPath = new FileInfo(minidump);

            // ToDo: We need API support for the Notes field
            notes = Program.crash_ini.Read("Notes", false);

            // Read default user/email from ini
            options.User = Program.crash_ini.Read("User", false);
            options.Email = Program.crash_ini.Read("Email", false);

            // If defaults for user/email are empty, get last user-entered values
            if (options.User.Length == 0)
            {
                Object? rval = userCredsKey?.GetValue(USER_NAME, null);
                options.User = rval?.ToString();                
            }

            if (options.Email.Length == 0)
            {
                Object? rval = userCredsKey?.GetValue(USER_EMAIL, null);
                options.Email = rval?.ToString();
            }

            // Update dialog text
            username.Text = options.User;
            email.Text = options.Email;

            string userDescription = Program.crash_ini.Read("UserDescription", false);
            options.Description = userDescription;

            // Add each file attachment
            int attachmentNumber = 0;
            logFilePath = Program.crash_ini.Read("LogFilePath", false);
            if (logFilePath.Length > 0)
            {
                attachmentNumber++;
                FileInfo logFile = new FileInfo(logFilePath);
                options.Attachments.Add(logFile);
            }

            while(true)
            {
                string fname = Program.crash_ini.Read("AdditionalFile" + attachmentNumber++, false);
                if (fname.Length <= 0) break;
                FileInfo item = new FileInfo(fname);
                options.Attachments.Add(item);
            }
        }

        private void userDescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            options.Description = userDescriptionTextbox.Text;
        }

        private async void sendErrorReportButton_Click(object sender, EventArgs e)
        {   
            if (minidumpPath != null)
            {
                BugSplat bs = new BugSplat(database, application, version);
                await bs.Post(minidumpPath, options);
            }
            Application.Exit();
        }

        private BugSplat.MinidumpTypeId stringToMinidumpTypeId( string typestr)
        {
            if( typestr.Equals("Windows.Native", StringComparison.OrdinalIgnoreCase) )
            {
                return BugSplat.MinidumpTypeId.WindowsNative;
            }
            else if(typestr.Equals("DotNet", StringComparison.OrdinalIgnoreCase))
            {
                return BugSplat.MinidumpTypeId.DotNet;
            }
            else if(typestr.Equals("UnityNativeWindows", StringComparison.OrdinalIgnoreCase))
            {
                return BugSplat.MinidumpTypeId.UnityNativeWindows;
            }

            return BugSplat.MinidumpTypeId.Unknown;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            options.Email = email.Text;
            userCredsKey?.SetValue(USER_EMAIL, email.Text);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            options.User = username.Text;
            userCredsKey?.SetValue(USER_NAME, username.Text);
        }

        private void viewReportDetailsButton_Click(object sender, EventArgs e)
        {
            CrashDataDetails dlg = new CrashDataDetails(options.Attachments);
            dlg.ShowDialog();
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

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
