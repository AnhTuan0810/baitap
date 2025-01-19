using System.ComponentModel.DataAnnotations.Schema;

namespace buoi3.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }


        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]

        public virtual Category Category { get; set; }
    }
}
