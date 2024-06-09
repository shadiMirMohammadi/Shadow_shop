using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_OrderLine")]
    public class OrderLine : BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int ProductItemId { get; set; } //FK


        [Required]
        public int OrderId { get; set; } //FK


        [Required]
        public int QTY { get; set; } //abbreviation for quantity


        [Required]
        public int Price { get; set; }







        public IEnumerable<UserReview> UserReviews { get; set; }
        public ProductItem ProductItem { get; set; }
        public ShopOrder ShopOrder { get; set; }
    }
}
