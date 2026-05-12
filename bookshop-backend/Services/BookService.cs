using bookshop_backend.DTOs;
using bookshop_backend.Models;
using bookshop_backend.Repositories;

namespace bookshop_backend.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;  //o service chama o repository, o repository chama o banco de dados

        public BookService(IBookRepository repository) 
        {
            _repository = repository;
        }
        public Book CreateBook(CreateBookDto createBookDto)
        {
            var book = new Book
            {
                Title = createBookDto.Title,
                Author = createBookDto.Author,
                Price = createBookDto.Price,
                CategoryId = createBookDto.CategoryId,
                Description = createBookDto.Description
            };

            _repository.CreateAsync(book);
            return book;
        }
    }
}
