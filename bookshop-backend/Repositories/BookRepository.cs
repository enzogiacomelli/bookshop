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
            var query = "SELECT * FROM Books WHERE Id = @Id";
            return await _connection.QuerySingleOrDefaultAsync<Book>(query, new { Id = id });
        }

        public async Task<List<Book>> GetAllAsync()
        {
            var query = "SELECT * FROM Books";
            var books = await _connection.QueryAsync<Book>(query);
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
