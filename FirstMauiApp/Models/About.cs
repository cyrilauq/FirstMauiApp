using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiApp.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "This app is written in XAML and C# with .NET MAUI.";
    public string Description => "This app is about a notes manager and it has been write to discover some little thing about .Net MAUI";
}