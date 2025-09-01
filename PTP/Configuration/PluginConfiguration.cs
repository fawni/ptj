using MediaBrowser.Model.Plugins;

namespace PTP.Configuration;

/// <summary>
/// Plugin configuration.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
    /// </summary>
    public PluginConfiguration()
    {
        // set default options here
        LinkName = "PTP";
    }

    /// <summary>
    /// Gets or sets a string setting.
    /// </summary>
    public string LinkName { get; set; }
}
