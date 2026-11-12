using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	[PrimaryKey(nameof(teacher), nameof(discipline))]
	public class TeachersDisciplinesRelation
	{
		[Column("teacher", TypeName = "SMALLINT")]
		[ForeignKey(nameof(Teacher))]
		public int teacher { get; set; }
		[Column("discipline", TypeName = "SMALLINT")]
		[ForeignKey(nameof(Discipline))]
		public int discipline { get; set; }

		// Navigation Properties:
		public Teacher Teacher { get; set; }
		public Discipline Discipline { get; set; }
	}
}
