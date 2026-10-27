using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Group
	{
		[Key]
		public int group_id { get; set; }
		[Required]
		[StringLength(10, MinimumLength = 4)]
		[Column("group_name", TypeName = "NCHAR(10)")]
		public string group_name { get; set; }
		[Required]
		[ForeignKey(nameof(Direction))]
		[Column("direction", TypeName = "TINYINT")]
		public int direction {  get; set; }
		[DisplayFormat(DataFormatString = "{0:yyyy.MM.dd}")]
		[Column("start_date", TypeName = "DATE")]
		public DateOnly? start_date { get; set; }
		[Column("start_time", TypeName = "TIME(0)")]
		public TimeOnly? start_time { get; set; }
		[Column("learning_days", TypeName = "TINYINT")]
		public int? learning_days { get; set; }

		//	Navigation properties
		public Direction Direction { get; set; }
	}
}
