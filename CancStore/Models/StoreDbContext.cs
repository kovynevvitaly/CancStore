using Microsoft.EntityFrameworkCore;

namespace CancStore.Models {
    public class StoreDbContext : DbContext {
        public DbSet<Product> Products { get; set; }
        public StoreDbContext(DbContextOptions options) : base(options) {}
    }
}