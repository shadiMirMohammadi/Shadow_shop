using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Shadow_shop.ModelsLayer;

namespace Shadow_shop.Views.ViewModels
{
    public class ProductCategoryViewModel
    {

        [Key]
        public int Id { get; set; }



        [Required]
        [Display(Name = "زیر دسته بندی")]
        public int ParentCategoryId { get; set; } //FK


        [Required]
        [MaxLength(50)]
        [Display(Name = "دسته بندی")]
        public string CategoryName { get; set; }


        public IEnumerable<ProductCategory> ProductCategorys { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Variation> Variations { get; set; }
        public IEnumerable<PromotionCategory> promotionCategories { get; set; }
    }
}