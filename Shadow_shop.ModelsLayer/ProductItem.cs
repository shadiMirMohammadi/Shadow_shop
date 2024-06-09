using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_ProductItem")]
    public class ProductItem : BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int ProductId { get; set; } //FK


        [Required]
        public bool IsActive { get; set; }


        [Required]
        public int QTY_Stock { get; set; }


        [Required]
        [MaxLength(70)]
        [Column(TypeName = "varchar")]
        public string ProductImage { get; set; }


        [Required]
        public int Price { get; set; }



        public Product Product { get; set; }
        public IEnumerable<ShoppingCartItem> ShoppingCartItems { get; set; }
        public IEnumerable<OrderLine> OrderLines { get; set; }
        public IEnumerable<ProductConfiguration> ProductConfigurations { get; set; }
    }
}
