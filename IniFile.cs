using System.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;


namespace BugSplatCrashHandler
{
    // See https://stackoverflow.com/questions/217902/reading-writing-an-ini-file
    class IniFile
    {
        string Path;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile()
        {
            Path = "";
        }

        public IniFile(string IniPath)
        {
            Path = new FileInfo(IniPath ?? "BsSndRpt" + ".ini").FullName;
        }

        public string Read(string Key, bool required = false)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString("BugSplat", Key, "", RetVal, 255, Path);

            if( RetVal.Length == 0 && required == true )
            {
                MessageBox.Show($"Missing required parameter {Key}");
                Application.Exit();
            }

            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string? Section = null)
        {
            WritePrivateProfileString(Section ?? "BugSplat", Key, Value, Path);
        }

        public void DeleteKey(string Key, string? Section = null)
        {
            Write(Key, "", Section ?? "BugSplat");
        }

        public void DeleteSection(string? Section = null)
        {
            Write("", "", Section ?? "BugSplat");
        }

        public bool KeyExists(string Key)
        {
            return Read(Key).Length > 0;
        }
    }
    
}
