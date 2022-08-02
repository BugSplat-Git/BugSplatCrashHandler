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
    public partial class CrashDataDetails : Form
    {
        public CrashDataDetails( List<FileInfo> Attachments )
        {
            InitializeComponent();

            foreach (FileInfo fInfo in Attachments)
            {
                this.dataGridView1.Rows.Add(fInfo.Name, fInfo.Directory);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
