using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Lesson
	{
		[Key]
		public long lesson_id { get; set; }
		[Required]
		[ForeignKey(nameof(Group))]
		public int group { get; set; }

		[Required]
		[Column(TypeName = "SMALLINT")]
		[ForeignKey(nameof(Discipline))]
		public int discipline { get; set; }

		[Required]
		[Column(TypeName = "SMALLINT")]
		[ForeignKey(nameof(Teacher))]
		public int teacher { get; set; }

		[Required]
		public DateOnly date { get; set; }

		[Required]
		public TimeOnly time { get; set; }

		public bool spent { get; set; }

		//Navigation properties:
		public Group Group { get; set; }
		public Discipline Discipline { get; set; }
		public Teacher Teacher { get; set; }
	}
}
