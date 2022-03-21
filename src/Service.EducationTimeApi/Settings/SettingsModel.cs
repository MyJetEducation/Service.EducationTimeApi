using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.EducationTimeApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationTimeApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationTimeApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationTimeApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationTimeApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
	}
}
