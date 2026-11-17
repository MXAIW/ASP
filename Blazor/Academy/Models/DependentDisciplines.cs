using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	[PrimaryKey(nameof(discipline), nameof(dependent_discipline))]
	public class DependentDisciplines
	{
		[Column("discipline", TypeName = "SMALLINT")]
		[ForeignKey(nameof(Discipline))]
		public int discipline { get; set; }
		[Column("dependent_discipline", TypeName = "SMALLINT")]
		[ForeignKey(nameof(DependentDiscipline))]
		public int dependent_discipline { get; set; }

		//Navigation properties:
		public Discipline Discipline { get; set; }
		public Discipline DependentDiscipline { get; set; }
	}
}
