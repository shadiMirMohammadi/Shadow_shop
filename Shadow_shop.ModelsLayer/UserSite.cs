using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_UserSite")]
    public class UserSite : Person
    {
        public Role Role { get; set; }

        public IEnumerable<UserAddress> UserAddresses { get; set; }
        public IEnumerable<UserReview> UserReviews{ get; set; }
        public IEnumerable<UserPaymentMethod> UserPaymentMethods { get; set; }
        public IEnumerable<ShoppingCart> ShoppingCarts { get; set; }



    }
}
