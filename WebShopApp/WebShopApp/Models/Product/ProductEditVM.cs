using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models.Product
{
    public class ProductEditVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "ProductName")]
        public string ProductName { get; set; } = null!;

        

    }
}
