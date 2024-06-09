using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_SupportSite")]
    public class SupportSite : Person
    {
        public Role Role { get; set; }
    }
}
