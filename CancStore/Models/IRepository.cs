namespace CancStore.Models;

public interface IRepository {
    public IQueryable<Product> Products { get; }
}