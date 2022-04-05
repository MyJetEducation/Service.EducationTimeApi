using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.WalletApi.EducationTimeApi.Settings
{
    public class SettingsModel
    {
        [YamlProperty("EducationTimeApi.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("EducationTimeApi.ZipkinUrl")]
        public string ZipkinUrl { get; set; }

        [YamlProperty("EducationTimeApi.ElkLogs")]
        public LogElkSettings ElkLogs { get; set; }

        [YamlProperty("EducationTimeApi.EnableApiTrace")]
        public bool EnableApiTrace { get; set; }

        [YamlProperty("EducationTimeApi.MyNoSqlReaderHostPort")]
        public string MyNoSqlReaderHostPort { get; set; }

        [YamlProperty("EducationTimeApi.AuthMyNoSqlReaderHostPort")]
        public string AuthMyNoSqlReaderHostPort { get; set; }

        [YamlProperty("EducationTimeApi.SessionEncryptionKeyId")]
        public string SessionEncryptionKeyId { get; set; }

        [YamlProperty("EducationTimeApi.MyNoSqlWriterUrl")]
        public string MyNoSqlWriterUrl { get; set; }

		[YamlProperty("EducationTimeApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
    }
}
