namespace CancStore.Models; 

public class Material {
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string? Status { get; set; }
    public DateOnly ManufactureDate { get; set; }
    public DateOnly ExpireDate { get; set; }
    public int ManufacturerId { get; set; }
    public int MaterialTypeId { get; set; }

    public List<MaterialStorageLocation> MaterialStorageLocations { get; set; } = new();
}