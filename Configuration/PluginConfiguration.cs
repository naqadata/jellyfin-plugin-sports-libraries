using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.SportsLibraries.Configuration;

public class PluginConfiguration : BasePluginConfiguration
{
    public string[] SportsLibraryIds { get; set; } = [];
}
