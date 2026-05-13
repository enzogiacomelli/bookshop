using bookshop_backend.Data;
using bookshop_backend.Models;
using Dapper;
using System.Data;

namespace bookshop_backend.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDbConnection _connection;

        public CategoryRepository(IDbConnectionFactory factory)
        {
            _connection = factory.CreateConnection();
        }

        public async Task<int> CreateAsync(Category category)
        {
            var query = "INSERT INTO Categories (Name) VALUES (@Name)";
            return await _connection.ExecuteAsync(query, category);

        }

        public async Task<Category> GetByIdAsync(string id)
        {
            var query = "SELECT * FROM Categories WHERE Id = @Id";
            return await _connection.QuerySingleOrDefaultAsync<Category>(query, new { Id = id });
        }
    }
}
