using System.ComponentModel.DataAnnotations;

namespace Service.EducationTimeApi.Models
{
	public class TaskTrueFalseRequest : TaskRequestBase
	{
		[Required]
		public TaskTrueFalse[] Answers { get; set; }
	}
}