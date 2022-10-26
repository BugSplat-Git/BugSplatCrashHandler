[![bugsplat-github-banner-basic-outline](https://user-images.githubusercontent.com/20464226/149019306-3186103c-5315-4dad-a499-4fd1df408475.png)](https://bugsplat.com)
<br/>
# <div align="center">BugSplat</div> 
### **<div align="center">Crash and error reporting built for busy developers.</div>**
<div align="center">
    <a href="https://twitter.com/BugSplatCo">
        <img alt="Follow @bugsplatco on Twitter" src="https://img.shields.io/twitter/follow/bugsplatco?label=Follow%20BugSplat&style=social">
    </a>
    <a href="https://discord.gg/K4KjjRV5ve">
        <img alt="Join BugSplat on Discord" src="https://img.shields.io/discord/664965194799251487?label=Join%20Discord&logo=Discord&style=social">
    </a>
</div>

## 👋 Introduction

BugSplatCrashHandler is a drop-in replacement for BsSndRpt and BsSndRpt64 built on .NET Framework 4.7.2. The .NET Framework is included on all systems running [Windows 7 or newer](https://learn.microsoft.com/en-us/dotnet/framework/migration-guide/versions-and-dependencies#net-framework-472). BugSplatCrashHandler allows you to customize the functionality, look, and feel of the crash report dialog in your application. Additionally, BugSplatCrashHandler leverages [BugSplatDotNetStandard](https://github.com/BugSplat-Git/bugsplat-dotnet-standard) which is also open source and customizable.

## 🧑‍💻 Development

Clone this repo

```sh
git clone https://github.com/BugSplat-Git/BugSplatCrashHandler
```

Double click `CrashReportForm.cs` to open the Form Designer.

![BugSplatCrashHandlerForm](https://user-images.githubusercontent.com/2646053/197914670-dbe6f1ff-1dc3-4c3a-9742-f1fc916e06b1.png)

Run the project to post a test crash to the public "Fred" database.

## ⚙️ Integration

To use BugSplatCrashHandler in your project, first integrate with BugSplat's Windows C++ or .NET Framework SDKs. Next, build the BugSplatCrashHandler project. Finally, rename BugSplatCrashHandler.exe,|exe.config|.pdb to BsSndRpt.exe|.exe.config|.pdb respectively. Generate a crash in your program and you should see the new dialog.
