namespace CancStore.Models; 

public class Product {
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string? Description { get; set; }

    public List<ProductMaterial> ProductMaterials { get; set; } = new();
}