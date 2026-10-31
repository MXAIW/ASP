using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Student : Human
	{
		[Key]
		public int stud_id { get; set; }
		public int group {  get; set; }
	}
}
