using Store.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Store.Database.Context
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Article> Articles { get; set; }

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
    }
}
