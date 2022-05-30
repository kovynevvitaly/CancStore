namespace CancStore.Models; 

public class MaterialType {
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Measure { get; set; } = "";
    public int ParameterId { get; set; }

    public List<Material> Materials { get; set; } = new();
}