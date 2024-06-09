using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_ShippingMethod")]
    public class ShippingMethod : BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }



        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }



        [Required]
        public int Price { get; set; }


        public IEnumerable<ShopOrder> ShopOrders { get; set; }
    }
}
