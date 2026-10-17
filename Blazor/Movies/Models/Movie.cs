using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
	public class Movie
	{
		public int id { get; set; }
		public string Title { get; set; }
		public DateOnly ReleaseDate { get; set; }
		public string URL { get; set; }
		public string Poster { get; set; }
	}
}
