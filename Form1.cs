using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugSplatCrashHandler
{
    public partial class CrashReportDialog : Form
    {
        public CrashReportDialog()
        {           
            InitializeComponent();

            string database = "";
            database = Program.crash_ini.Read("Database");
            if( database == "")
            {
                database = Program.crash_ini.Read("Vendor");
                if( database == "")
                {
                    MessageBox.Show("No database property found!");
                    Application.Exit();
                }
            }

            string application = Program.crash_ini.Read("Application", true);
            string version = Program.crash_ini.Read("Version", true);
            string crashType = Program.crash_ini.Read("CrashType", true);
            string minidump = Program.crash_ini.Read("MiniDump", true);

            string notes = Program.crash_ini.Read("Notes", false);
            string user = Program.crash_ini.Read("User", false);
            string email = Program.crash_ini.Read("Email", false);
            string userDescription = Program.crash_ini.Read("UserDescription", false);
            string logFilePath = Program.crash_ini.Read("LogFilePath", false);

            //AdditionalFile0 = "C:\www\src\BugSplat\BsSndRpt\testdata\TestFile1.txt"
            //AdditionalFile1 = "C:\www\src\BugSplat\BsSndRpt\testdata\错误是坏的.txt"
            //AdditionalFile2 = "C:\www\src\BugSplat\BsSndRpt\testdata\TestFile2.txt"
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userDescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            // What happens here?
            String lstr = userDescriptionTextbox.Text;
        }

        private void sendErrorReportButton_Click(object sender, EventArgs e)
        {
            // Zip and send files
            String lstr = userDescriptionTextbox.Text;
        }
    }
}
