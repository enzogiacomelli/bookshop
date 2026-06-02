using bookshop_backend.Data;
using bookshop_backend.Models;
using Dapper;
using System.Data;

namespace bookshop_backend.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IDbConnection _connection;

        public BookRepository(IDbConnectionFactory factory)
        {
            _connection = factory.CreateConnection();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            var query = @"
                SELECT Books.Id, Books.Title, Books.Author, Books.Price, 
                       Books.CategoryId, Books.Description,
                       Categories.Id, Categories.Name
                FROM Books 
                JOIN Categories ON Books.CategoryId = Categories.Id 
                WHERE Books.Id = @Id";

            var books = await _connection.QueryAsync<Book, Category, Book>(query, (book, category) =>
            {
                book.Category = category;
                return book;
            },
            new { Id = id },
            splitOn: "Id"
            );

            return books.FirstOrDefault();
        }

        public async Task<List<Book>> GetAllAsync()
        {
            var query = @"
                SELECT Books.Id, Books.Title, Books.Author, Books.Price, 
                       Books.CategoryId, Books.Description,
                       Categories.Id, Categories.Name
                FROM Books 
                JOIN Categories ON Books.CategoryId = Categories.Id";
            var books = await _connection.QueryAsync<Book, Category, Book>(query, (book, category) =>
            {
                book.Category = category;
                return book;
            }, 
            splitOn: "Id"
            );
            return books.ToList();
        }

        public async Task<int> CreateAsync(Book book)
        {
            var query = @"INSERT INTO Books (Title, Author, Price, CategoryId, Description) 
                     VALUES (@Title, @Author, @Price, @CategoryId, @Description)";
            
            return await _connection.ExecuteAsync(query, book);
        }
    }
}
