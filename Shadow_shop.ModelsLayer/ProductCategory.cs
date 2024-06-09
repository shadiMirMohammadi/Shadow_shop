using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_ProductCategory")]
    public class ProductCategory : BaseEntity
    {

        [Key]
        public int Id { get; set; }



        [Required]
        public int ParentCategoryId { get; set; } //FK



        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string CategoryName { get; set; }





        public IEnumerable<ProductCategory> ProductCategorys { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Variation> Variations { get; set; }
        public IEnumerable<PromotionCategory> promotionCategories { get; set; }
    }
}
