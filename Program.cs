using BugSplatDotNetStandard;
using CommandLine;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugSplatCrashHandler
{
    static class Program
    {
        public static IniFile CrashIni { get; private set; } = new IniFile();

        public static readonly string USER_CREDS_REGISTRY_KEY_PATH = "Software\\BugSplat\\UserCredentials";
        public static readonly string USER_NAME_REGISTRY_KEY = "UserName";
        public static readonly string USER_EMAIL_REGISTRY_KEY = "UserEmail";

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
            while (!Debugger.IsAttached)
            {
                System.Threading.Thread.Sleep(100);
            }
            
            // We won't get here if IniFile is null, but the compiler can't figure that out
            if (opts.IniFile != null)
            {
                CrashIni = new IniFile(opts.IniFile);
            }

            var options = new MinidumpPostOptions();

            // User entered credentials saved here
            var userCredsKey = Registry.CurrentUser.CreateSubKey(USER_CREDS_REGISTRY_KEY_PATH);

            // Allow either Database or Vendor (legacy) for database property
            var database = CrashIni.Read("Database");
            database = string.IsNullOrEmpty(database) ? CrashIni.Read("Vendor") : database;
            if (string.IsNullOrEmpty(database))
            {
                MessageBox.Show("No database property found!", "Error");
                Environment.Exit(1);
            }

            var application = CrashIni.Read("Application", true);
            var version = CrashIni.Read("Version", true);

            var crashType = CrashIni.Read("CrashType", true);
            options.MinidumpType = StringToMinidumpTypeId(crashType);

            var minidumpPath = CrashIni.Read("MiniDump", true);
            var minidump = new FileInfo(minidumpPath);

            // ToDo: We need API support for the Notes field
            var notes = CrashIni.Read("Notes", false);

            // Read default user/email from ini
            options.User = CrashIni.Read("User", false);
            options.Email = CrashIni.Read("Email", false);

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

            var userDescription = CrashIni.Read("UserDescription", false);
            options.Description = userDescription;

            // Add each file attachment
            var logFilePath = CrashIni.Read("LogFilePath", false);
            if (logFilePath.Length > 0)
            {
                var logFile = new FileInfo(logFilePath);
                if (logFile.Exists)
                {
                    options.Attachments.Add(logFile);
                }
            }

            var attachmentIndex = 0;
            while (true)
            {
                var fname = CrashIni.Read("AdditionalFile" + attachmentIndex++, false);
                if (fname.Length <= 0)
                {
                    break;
                }
                var item = new FileInfo(fname);
                if (item.Exists)
                {
                    options.Attachments.Add(item);
                }
            }

            var bugsplat = new BugSplat(database, application, version);

            if (opts.QuietMode && !minidump.Exists)
            {
                Environment.Exit(1);
            }

            if (opts.QuietMode && minidump.Exists)
            {
                var poster = new CrashPoster(bugsplat);
                poster.PostCrashAndDisplaySupportResponseIfAvailable(minidump, options);
                Environment.Exit(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CrashDialogForm(bugsplat, minidump, options));
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

        private static BugSplat.MinidumpTypeId StringToMinidumpTypeId(string typestr)
        {
            if (typestr.Equals("Windows.Native", StringComparison.OrdinalIgnoreCase))
            {
                return BugSplat.MinidumpTypeId.WindowsNative;
            }
            else if (typestr.Equals("Windows.NET", StringComparison.OrdinalIgnoreCase))
            {
                return BugSplat.MinidumpTypeId.DotNet;
            }
            else if (typestr.Equals("UnityNativeWindows", StringComparison.OrdinalIgnoreCase))
            {
                return BugSplat.MinidumpTypeId.UnityNativeWindows;
            }

            return BugSplat.MinidumpTypeId.Unknown;
        }
    }
}
