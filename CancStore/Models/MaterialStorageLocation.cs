namespace CancStore.Models; 

public class MaterialStorageLocation {
    public int Id { get; set; }
    public int MaterialId { get; set; }
    public int StorageLocationId { get; set; }
    public double StoredQuantity { get; set; }
}