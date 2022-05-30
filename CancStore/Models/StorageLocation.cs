namespace CancStore.Models; 

public class StorageLocation {
    public int Id { get; set; }
    public string Name { get; set; } = "";

    public List<MaterialStorageLocation> MaterialStorageLocations { get; set; } = new();
}