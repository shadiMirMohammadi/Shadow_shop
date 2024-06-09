using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_ShopOrder")]
    public class ShopOrder : BaseEntity
    {
        [Key]
        public int Id { get; set; }



        [Required]
        public int UserId { get; set; } //FK


        [Required]
        public DateTime OrderDate { get; set; }


        [Required]
        public int PaymentMethodId { get; set; }//FK


        [Required]
        public int ShippingAddressId { get; set; }//FK


        [Required]
        public int ShippingMethodId { get; set; }//FK


        [Required]
        public int OrderTotal { get; set; }


        [Required]
        public int OrderStatusId { get; set; }//FK





        public Address Address { get; set; }
        public IEnumerable<OrderLine> OrderLines { get; set; }
        public IEnumerable<UserPaymentMethod> UserPaymentMethods { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
}
