using Microsoft.EntityFrameworkCore;
using bookshop_backend.Models;

namespace bookshop_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
