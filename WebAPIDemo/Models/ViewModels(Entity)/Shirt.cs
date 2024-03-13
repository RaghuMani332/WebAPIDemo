using System.ComponentModel.DataAnnotations;

namespace WebAPIDemo.Models
{
    public class Shirt
    {
        [Key]
        public int ShirtId { get; set; }
        public string Brand { get; set; }
        public int Size { get; set; }
        public string Gender { get; set; }
        public decimal Price { get; set; }
    }
}
