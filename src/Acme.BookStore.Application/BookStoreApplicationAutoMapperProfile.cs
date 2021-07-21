using Acme.BookStore.Books;
using AutoMapper;

namespace Acme.BookStore
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            //Need to map Book entities to BookDto object while returning book to the presenation layer.
            //public IMappingExpression<TSource, TDestination> CreateMap<TSource, TDestination>();
            CreateMap<Book, BookDto>(); // mapping to BookDto from Book
            CreateMap<CreateUpdateBookDto, Book>(); // mapping to Book from CreateUpdateBookDto
        }
    }
}
