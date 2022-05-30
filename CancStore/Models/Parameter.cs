namespace CancStore.Models; 

public class Parameter {
    public int Id { get; set; }
    public string Name { get; set; } = "";

    public List<Norm> Norms { get; set; } = new();
    public List<MaterialType> MaterialTypes { get; set; } = new();
}