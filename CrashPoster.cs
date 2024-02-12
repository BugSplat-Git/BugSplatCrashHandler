using BugSplatDotNetStandard;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace BugSplatCrashHandler
{
    public class CrashPoster
    {
        private BugSplat bugsplat;

        public CrashPoster (BugSplat bugsplat)
        {
            this.bugsplat = bugsplat;
        }

        public void PostCrashAndDisplaySupportResponseIfAvailable(FileInfo crashReportFile, MinidumpPostOptions options)
        {
            string body = null;
            if (crashReportFile.Extension.Equals(".dmp"))
            {
                body = Task.Run(async () =>
                {
                    var response = await bugsplat.Post(crashReportFile, options);
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }).Result;
            }
            else if (crashReportFile.Extension.Equals(".xml"))
            {
                body = Task.Run(async () =>
                {
                    // ToDo: Post to xmlReport method
                    var response = await bugsplat.Post(crashReportFile, options);
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }).Result;
            }

            var json = JObject.Parse(body);
            var infoUrl = json["infoUrl"]?.ToString();

            if (!string.IsNullOrEmpty(infoUrl))
            {
                Process.Start(infoUrl);
            }
        }
    }
}
