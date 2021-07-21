using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Books
{
	public class CreateUpdateBookDto
	{
		//This class use to get in4 from user type in the UI 
		[Required]
		[StringLength(128)]
		public string Name { get; set; }

		[Required]
		public BookType Type { get; set; } = BookType.Undefined;

		[Required]
		[DataType(DataType.Date)]
		public DateTime PubplishDate { get; set; } = DateTime.Now;

		[Required]
		public float Price { get; set; }
	}
}
