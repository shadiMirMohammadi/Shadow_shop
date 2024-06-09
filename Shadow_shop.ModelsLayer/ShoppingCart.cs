using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_ShoppingCart")]
    public class ShoppingCart : BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int UserId { get; set; } //FK


        public UserSite UserSite { get; set; }
        public IEnumerable<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
