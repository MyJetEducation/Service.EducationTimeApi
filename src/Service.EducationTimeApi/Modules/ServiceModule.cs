using Autofac;
using Microsoft.Extensions.Logging;
using Service.Core.Client.Services;
using Service.TutorialTime.Client;

namespace Service.EducationTimeApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterTutorialTimeClient(Program.Settings.EducationFlowServiceUrl, Program.LogFactory.CreateLogger(typeof(TutorialTimeClientFactory)));

			builder.RegisterType<SystemClock>().AsImplementedInterfaces().SingleInstance();

			builder.Register(context => new EncoderDecoder(Program.EncodingKey))
				.As<IEncoderDecoder>()
				.SingleInstance();
		}
	}
}
