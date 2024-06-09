using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Shadow_shop.ModelsLayer.Context
{
    public class CmsContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AdminSite> AdminSites { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductConfiguration> ProductConfigurations { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PromotionCategory> PromotionCategories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShippingMethod> ShippingMethods { get; set; }
        public DbSet<ShopOrder> ShopOrders { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<SupportSite> SupportSites { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserPaymentMethod> UserPaymentMethods { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        public DbSet<UserSite> UserSites { get; set; }
        public DbSet<Variation> Variations { get; set; }
        public DbSet<VariationOption> VariationOptions { get; set; }
    }
}
