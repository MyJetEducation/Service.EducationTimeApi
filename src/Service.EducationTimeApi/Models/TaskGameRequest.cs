using System.ComponentModel.DataAnnotations;

namespace Service.EducationTimeApi.Models
{
	public class TaskGameRequest : TaskRequestBase
	{
		[Required]
		public bool Passed { get; set; }
	}
}