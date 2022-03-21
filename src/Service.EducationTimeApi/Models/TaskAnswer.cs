using System.ComponentModel.DataAnnotations;

namespace Service.EducationTimeApi.Models
{
	public class TaskAnswer
	{
		[Required]
		public int Number { get; set; }

		[Required]
		public int[] Value { get; set; }
	}
}