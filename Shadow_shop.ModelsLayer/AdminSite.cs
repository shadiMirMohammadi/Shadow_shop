using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Shadow_shop.ModelsLayer
{
    [Table("T_AdminSite")]
    public class AdminSite : Person 
    {
        public Role Role { get; set; }
        public IEnumerable<Promotion> Promotions { get; set; }
    }
}
