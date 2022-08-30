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

        public void PostCrashAndDisplaySupportResponseIfAvailable(FileInfo minidump, MinidumpPostOptions options)
        {
            var body = Task.Run(async () => {
                var response = await bugsplat.Post(minidump, options);
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }).Result;

            var json = JObject.Parse(body);
            var infoUrl = json["infoUrl"]?.ToString();

            if (!string.IsNullOrEmpty(infoUrl))
            {
                Process.Start(infoUrl);
            }
        }
    }
}
