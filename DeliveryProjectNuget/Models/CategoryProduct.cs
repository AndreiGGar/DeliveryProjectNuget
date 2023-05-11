using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryProjectNuget.Models
{
    [Table("CategoriesProducts")]
    public class CategoryProduct
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("RestaurantId")]
        public int RestaurantId { get; set; }
        [Column("Name")]
        public string Name { get; set; }
    }
}
