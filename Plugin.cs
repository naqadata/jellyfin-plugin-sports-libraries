using System;
using System.Collections.Generic;
using System.Globalization;
using Jellyfin.Plugin.SportsLibraries.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.SportsLibraries;

public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
{
    public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer) => Instance = this;
    public override string Name => "Sports Libraries";
    public override Guid Id => Guid.Parse("c3ee83f8-0f0b-4e78-a7e7-a9840e10f043");
    public static Plugin? Instance { get; private set; }
    public IEnumerable<PluginPageInfo> GetPages() =>
    [new PluginPageInfo { Name = Name, EmbeddedResourcePath = string.Format(CultureInfo.InvariantCulture, "{0}.Configuration.configPage.html", GetType().Namespace) }];
}
