using System.ComponentModel.DataAnnotations;

namespace CancStore.Models {
    public class Product {
        public long Id { get; set; }
        public string Name { get; set; }
        [DataType("decimal(8, 2)")]  
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}