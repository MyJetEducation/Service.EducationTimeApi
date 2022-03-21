using System.ComponentModel.DataAnnotations;

namespace Service.EducationTimeApi.Models
{
	public class TaskTestRequest : TaskRequestBase
	{
		[Required]
		public TaskAnswer[] Answers { get; set; }
	}
}