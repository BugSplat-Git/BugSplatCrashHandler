using CommandLine;

namespace BugSplatCrashHandler
{
    static class Program
    {
        public static IniFile crash_ini = new IniFile();

        public class Options
        {
            [Option('i', "iniFile", Required = false, HelpText = "Configuration file.")]
            public String? IniFile { get; set; }

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
                crash_ini = new IniFile(opts.IniFile);
            }

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
