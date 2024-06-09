using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Shadow_shop.ModelsLayer
{
    [Table("T_UserPaymentMethod")]
    public class UserPaymentMethod : BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int UserId { get; set; } //FK


        [Required]
        public int OrderTotal { get; set; }


        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar")]
        public string ShippingMethod { get; set; }


        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar")]
        public string BankName { get; set; }


        [Required]
        public DateTime RegisterDate { get; set; }




        public UserSite UserSite { get; set; }
        public ShopOrder ShopOrder { get; set; }
    }
}
