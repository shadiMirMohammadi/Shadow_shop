using Shadow_shop.ModelsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Shadow_shop.Views.ViewModels
{
    public class RoleViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name ="عنوان")]
        public string Title { get; set; }


        public IEnumerable<UserSite> UserSites { get; set; }
        public IEnumerable<AdminSite> AdminSites { get; set; }
        public IEnumerable<SupportSite> SupportSites { get; set; }
    }
}