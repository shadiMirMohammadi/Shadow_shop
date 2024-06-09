using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_Promotion")]
    public class Promotion : BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }


        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Description { get; set; }




        [Required]
        public float DiscountRate { get; set; }



        [Required]
        public DateTime StartDate { get; set; }



        [Required]
        public DateTime EndDate { get; set; }



        [Required]
        public int AdminId { get; set; } //FK





        public AdminSite AdminSite { get; set; }
        public IEnumerable<PromotionCategory> PromotionCategory { get; set; }
    }
}
