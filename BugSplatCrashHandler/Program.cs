using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandLine;

namespace BugSplatCrashHandler
{
    static class Program
    {
        

        public class Options
        {
            [Option('i', "iniFile", Required = true, HelpText = "Configuration file.")]
            public String IniFile { get; set; }

            [Option('q', "quietMode", Required = false, HelpText = "Don't prompt for user input.")]
            public bool QuietMode { get; set; }

            [Option('z', "zipFile", Required = false, HelpText = "Zipped crash report to upload.")]
            public bool ZipFile { get; set; }
        }

        static void RunOptions(Options opts)
        {
            IniFile crash_ini = new IniFile(opts.IniFile);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CrashReportDialog());
        }
        static void HandleParseError(IEnumerable<Error> errs)
        {
            MessageBox.Show(errs.ToString(), "BugSplat Crash Handler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            CommandLine.Parser.Default.ParseArguments<Options>(args)
                                  .WithParsed(RunOptions)
                                  .WithNotParsed(HandleParseError);

        }
    }
}
