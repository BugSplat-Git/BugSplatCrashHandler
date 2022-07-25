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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userDescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            // What happens here?
            String lstr = userDescriptionTextbox.Text;
            lstr = lstr + "!!!";
        }
    }
}
