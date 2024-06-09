using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_Variation")]
    public class Variation : BaseEntity
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int CategoryId { get; set; } //FK


        [Required]
        [MaxLength(30)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }




        public ProductCategory ProductCategory { get; set; }
        public IEnumerable<VariationOption> VariationOptions { get; set; }
    }
}
