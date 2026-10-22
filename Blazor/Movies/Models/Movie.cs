using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
	//Movie - это модель 
	//Модель - это класс, описывающий данные, хранящиеся в Базе данных
	//А точнее, модель описывает структуру записи определённой таблицы в базе данных
	//а именно каждое поле в Модели соотвествует определённому полю в таблице базе данных
	public class Movie
	{
		public int id { get; set; }

		//[DataAnnotation] - пишутся в квардратных скобках перед моделью и перед её полями,
		//и предназначены для уточнения свойств модели либо её полей
		[Required(ErrorMessage = "Кино без названия как самурай без меча")]
		[StringLength(100, MinimumLength = 2)]
		public string Title { get; set; }
		[Range(typeof(DateOnly), "1888-10-14", "2029-12-31")]
		[DisplayFormat(DataFormatString = "{0:yyyy.MM.dd}", ApplyFormatInEditMode = true)] // НЕ РАБОТАЕТ в blazor
		public DateOnly ReleaseDate { get; set; }
		public string URL { get; set; }
		public string Poster { get; set; }
	}
}
