using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_UserAddress")]
    public class UserAddress : BaseEntity
    {
        [Key]
        public int Id { get; set; }




        [Required]    
        public int UserId { get; set; } //FK


        [Required]
        public int AddressId { get; set; } //FK


        public bool IsDefault { get; set; }






        public Address Adress { get; set; }
        public UserSite UserSite { get; set; }

    }
}
