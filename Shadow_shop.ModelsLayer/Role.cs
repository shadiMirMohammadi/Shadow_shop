using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_Role")]
    public class Role : BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(TypeName = "nvarchar")]
        public string Title { get; set; }


        public IEnumerable<UserSite> UserSites { get; set; }
        public IEnumerable<AdminSite> AdminSites { get; set; }
        public IEnumerable<SupportSite> SupportSites { get; set; }
    }
}
