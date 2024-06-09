using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_VariationOption")]
    public class VariationOption : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int VariationId { get; set; } //FK

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Value { get; set; }



        public Variation Variation { get; set; }
        public IEnumerable<ProductConfiguration> ProductConfigurations { get; set; }
    }
}
