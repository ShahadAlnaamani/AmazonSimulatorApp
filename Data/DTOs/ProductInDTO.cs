using System.ComponentModel.DataAnnotations;

namespace AmazonSimulatorApp.Data.DTOs
{
    public class ProductInDTO
    {

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public int CatID { get; set; }
        public int SellerID { get; set; }

        [Required]
        [Range(minimum: 0.1, maximum: int.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(minimum: 0, maximum: int.MaxValue)]
        public int Stock { get; set; }
    }
}

