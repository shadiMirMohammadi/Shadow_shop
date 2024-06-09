using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_UserReview")]
    public class UserReview : BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int UserId { get; set; } //FK


        [Required]
        public int OrderedProductId { get; set; }//FK


        [Required]
        [MaxLength(5)]
        public string RatingValue { get; set; } //1 .... 5


        [Required]
        [MaxLength(200)]
        [Column(TypeName = "nvarchar")]
        public string Comment { get; set; }


        [Required]
        public DateTime RegisterDate { get; set; }






        public UserSite UserSite { get; set; }
        public OrderLine OrderLine { get; set; }

    }
}
