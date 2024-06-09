using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_PromotionCategory")]
    public class PromotionCategory : BaseEntity
    {
        [Key]
        public int Id { get; set; }



        [Required]    
        public int CategoryId { get; set; } //FK

        [Required]      
        public int PromotionId { get; set; } //FK





        public ProductCategory ProductCategory { get; set; }
        public Promotion Promotion { get; set; }
    }
}
