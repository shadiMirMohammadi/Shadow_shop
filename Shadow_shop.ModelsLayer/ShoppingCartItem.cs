using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_ShoppingCartItem")]
    public class ShoppingCartItem : BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int CartId { get; set; } //FK


        [Required]
        public int ProductItemId { get; set; } //FK


        [Required]
        public int QTY { get; set; }





        public ShoppingCart ShoppingCart { get; set; }
        public ProductItem ProductItem { get; set; }
    }
}
