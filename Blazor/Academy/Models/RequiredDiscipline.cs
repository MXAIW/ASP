using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	[PrimaryKey(nameof(discipline), nameof(required_discipline))]
	public class RequiredDisciplines
	{
		[Column("discipline", TypeName = "SMALLINT")]
		[ForeignKey(nameof(Discipline))]
		public int discipline {  get; set; }

		[Column("required", TypeName = "SMALLINT")]
		[ForeignKey(nameof(required_discipline))]
		public int required_discipline { get; set; }

		//Navigation properties:
		public Discipline Discipline { get; set; }
		public Discipline RequiredDiscipline { get; set; }
	}
}
