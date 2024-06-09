using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_OrderStatus")]
    public class OrderStatus : BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(20)]
        [Column(TypeName = "nvarchar")]
        public string Status { get; set; }





        public IEnumerable<ShopOrder> ShopOrders { get; set; }

    }
}
