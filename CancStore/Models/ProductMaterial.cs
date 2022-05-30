namespace CancStore.Models; 

public class ProductMaterial {
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int MaterialId { get; set; }
    public double Quantity { get; set; }
}