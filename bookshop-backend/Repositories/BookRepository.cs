using bookshop_backend.Models;
using Dapper;
using System.Data;

namespace bookshop_backend.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IDbConnection _connection;

        public BookRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<Book> GetByIdAsync(string id)
        {
            var query = "SELECT * FROM Books WHERE Id = @Id";
            return await _connection.QuerySingleOrDefaultAsync<Book>(query, new { Id = id });
        }

        public async Task<int> CreateAsync(Book book)
        {
            var query = @"INSERT INTO Books (Id, Title, Author, Price, CategoryId, Description) 
                     VALUES (@Id, @Title, @Author, @Price, @CategoryId, @Description)";
            return await _connection.ExecuteAsync(query, book);
        }
    }
}
