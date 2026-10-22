using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Direction
	{
		public byte direction_id { get; set; }
		public string direction_name { get; set; }
	}
}
