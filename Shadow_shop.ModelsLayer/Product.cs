using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_Product")]
    public class Product : BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int CategoryId { get; set; } //FK

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }


        [Required]
        [MaxLength(500)]
        [Column(TypeName = "nvarchar")]
        public string Description { get; set; }


        [Required]
        [MaxLength(70)]
        [Column(TypeName = "varchar")]
        public string ProductImage { get; set; }


        public ProductCategory ProductCategory { get; set; }
        public IEnumerable<ProductItem> ProductItems { get; set; }


    }
}
