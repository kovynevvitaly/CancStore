namespace CancStore.Models;

public class StoreRepository : IRepository {
    private readonly StoreDbContext _storeDbContext;

    public StoreRepository(StoreDbContext storeDbContext) {
        _storeDbContext = storeDbContext;
    }

    public IQueryable<Product> Products => _storeDbContext.Products;
}