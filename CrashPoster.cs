using BugSplatDotNetStandard;
using BugSplatDotNetStandard.Http;
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

        public void PostCrashAndDisplaySupportResponseIfAvailable(FileInfo crashReportFile, BugSplatPostOptions options)
        {
            var body = Task.Run(async () =>
            {
                var response = await bugsplat.Post(crashReportFile, options);
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }).Result;
            var json = new JsonObject(body);
            var infoUrl = json.GetValue(new string[] { "infoUrl" });          

            if (!string.IsNullOrEmpty(infoUrl))
            {
                Process.Start(infoUrl);
            }
        }
    }
}
