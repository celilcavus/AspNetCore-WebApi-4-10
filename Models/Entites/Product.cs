using System.ComponentModel.DataAnnotations.Schema;

namespace CelilCavus.WebApi.Entites
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        [ForeignKey("CategoryId")] 
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}