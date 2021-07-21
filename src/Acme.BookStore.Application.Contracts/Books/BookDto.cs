using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
	//BookDto transfer book data to presentation layer -> show book data to UI
	public class BookDto : AuditedEntityDto<Guid>
	{
		public string Name { get; set; }

		public BookType Type { get; set; }

		public DateTime PubplishDate { get; set; }

		public float Price { get; set; }
	}
}
