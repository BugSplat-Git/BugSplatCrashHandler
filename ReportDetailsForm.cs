using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BugSplatCrashHandler
{
    public partial class ReportDetailsForm : Form
    {
        public ReportDetailsForm(IEnumerable<FileInfo> Attachments)
        {
            InitializeComponent();

            foreach (var fileInfo in Attachments)
            {
                attachmentsGridView.Rows.Add(fileInfo.Name, fileInfo.Directory);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
