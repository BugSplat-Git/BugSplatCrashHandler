using CommandLine;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BugSplatCrashHandler
{
    static class Program
    {
        public static IniFile CrashIni { get; private set; } = new IniFile();

        public class Options
        {
            [Option('i', "iniFile", Required = false, HelpText = "Configuration file.")]
            public string IniFile { get; set; }

            [Option('q', "quietMode", Required = false, HelpText = "Don't prompt for user input.")]
            public bool QuietMode { get; set; }

            [Option('z', "zipFile", Required = false, HelpText = "Zipped crash report to upload.")]
            public bool ZipFile { get; set; }
        }

        static void RunOptions(Options opts)
        {
            // We won't get here if IniFile is null, but the compiler can't figure that out
            if (opts.IniFile != null)
            {
                CrashIni = new IniFile(opts.IniFile);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CrashDialogForm());
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
            var args = Environment.GetCommandLineArgs();
            Parser.Default.ParseArguments<Options>(args)
                                  .WithParsed(RunOptions)
                                  .WithNotParsed(HandleParseError);

        }
    }
}
