using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{

	//ICrudAppService include GetAsync, GetListAsync, CreateAsync, UpdateAsync, Delete Async
	public interface IBookAppService : 
		ICrudAppService<
			BookDto, //Used to show books
			Guid, //Primary key of the book entity
			PagedAndSortedResultRequestDto, // Used to paging data and sorting
			CreateUpdateBookDto> // Used to create/update book
	{

	}
}
