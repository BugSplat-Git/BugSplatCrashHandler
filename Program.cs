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

            // TODO DP handle 'f' (MDSF_LOGFILE)
            [Option('f', "logToFile", Required = false, HelpText = "Write BugSplatCrashHandler log statements to a file.")]
            public bool LogToFile { get; set; }

            // TODO DP handle 'l' (MDSF_LOGCONSOLE)
            [Option('l', "logToConsole", Required = false, HelpText = "Write BugSplatCrashHandler log statements to standard output.")]
            public bool LogToConsole { get; set; }
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
            new Parser(with => { with.IgnoreUnknownArguments = true; })
                .ParseArguments<Options>(args)
                .WithParsed(RunOptions)
                .WithNotParsed(HandleParseError);

        }
    }
}
