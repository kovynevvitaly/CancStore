namespace CancStore.Models; 

public class Manufacturer {
    public int Id { get; set; }
    public string Name { get; set; } = "";

    public List<Material> Materials { get; set; } = new();
}