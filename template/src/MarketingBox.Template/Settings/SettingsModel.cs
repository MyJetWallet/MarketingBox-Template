using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace MarketingBox.Template.Settings
{
    public class SettingsModel
    {
        [YamlProperty("MarketingBox.Template.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("MarketingBox.Template.ZipkinUrl")]
        public string ZipkinUrl { get; set; }

        [YamlProperty("MarketingBox.Template.ElkLogs")]
        public LogElkSettings ElkLogs { get; set; }
    }
}
