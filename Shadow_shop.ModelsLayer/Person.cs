using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    public abstract class Person : BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }

        [MaxLength(30)]
        [Column(TypeName = "nvarchar")]
        public string Family { get; set; }

        [Required]
        [MaxLength(11)]
        [Column(TypeName = "char")]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(TypeName = "varchar")]
        public string Password { get; set; }

        [Required]
        public DateTime RegisterDate { get; set; }


        [Required]
        public bool IsActive { get; set; }


        [Required]
        public int RoleId { get; set; } //FK
    }
}
