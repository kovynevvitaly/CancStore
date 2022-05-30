using Microsoft.EntityFrameworkCore;

namespace CancStore.Models {
    public class StoreDbContext : DbContext {
        public StoreDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Manufacturer> Manufacturers => Set<Manufacturer>();
        public DbSet<Material> Materials => Set<Material>();
        public DbSet<MaterialStorageLocation> MaterialStorageLocations => Set<MaterialStorageLocation>();
        public DbSet<MaterialType> MaterialTypes => Set<MaterialType>();
        public DbSet<Norm> Norms => Set<Norm>();
        public DbSet<Parameter> Parameters => Set<Parameter>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductMaterial> ProductMaterials => Set<ProductMaterial>();
        public DbSet<StorageLocation> StorageLocations => Set<StorageLocation>();
    }
}