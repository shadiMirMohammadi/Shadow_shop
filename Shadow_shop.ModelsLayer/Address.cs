using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_Adress")]
    public class Address : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UnitNumber { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string StreetName { get; set; }


        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string AdressLine1 { get; set; }



        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string AdressLine2 { get; set; }


        [Required]
        [MaxLength(40)]
        [Column(TypeName = "nvarchar")]
        public string City { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(TypeName = "nvarchar")]
        public string State { get; set; }

        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }





        public IEnumerable<UserAddress> UserAddresses { get; set; }
        public IEnumerable<ShopOrder> ShopOrders { get; set; }

    }
}
