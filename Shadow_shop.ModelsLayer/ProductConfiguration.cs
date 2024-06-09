using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_ProductConfiguration")]
    public class ProductConfiguration : BaseEntity
    {
        [Key]
        public int Id { get; set; }




        [Required]     
        public int ProductItemId { get; set; } //FK

        [Required] 
        public int VariationOptionId { get; set; } //FK




        public ProductItem ProductItem { get; set; }
        public VariationOption VariationOption { get; set; }
    }
}
