using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Student : Human
	{
		[Key]
		public int stud_id { get; set; }
		[ForeignKey(nameof(Group))]
		public int group {  get; set; }

		//Navigation propecties
		public Group Group { get; set; }
	}
}
