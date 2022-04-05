using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationTimeApi.Controllers.Contracts
{
	public class TaskTestRequest : TaskRequestBase
	{
		[Required]
		public TaskAnswer[] Answers { get; set; }
	}
}