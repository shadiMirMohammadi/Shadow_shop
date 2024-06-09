namespace Shadow_shop.ModelsLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_Adress",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnitNumber = c.Int(nullable: false),
                        StreetName = c.String(nullable: false, maxLength: 50),
                        AdressLine1 = c.String(nullable: false, maxLength: 100),
                        AdressLine2 = c.String(maxLength: 100),
                        City = c.String(nullable: false, maxLength: 40),
                        State = c.String(nullable: false, maxLength: 20),
                        PostalCode = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.T_AdminSite",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        Family = c.String(maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        Password = c.String(nullable: false, maxLength: 20, unicode: false),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.T_Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.T_OrderLine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductItemId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        QTY = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        ShopOrder_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_ProductItem", t => t.ProductItemId, cascadeDelete: true)
                .ForeignKey("dbo.T_ShopOrder", t => t.ShopOrder_Id)
                .Index(t => t.ProductItemId)
                .Index(t => t.ShopOrder_Id);
            
            CreateTable(
                "dbo.T_ProductItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        QTY_Stock = c.Int(nullable: false),
                        ProductImage = c.String(nullable: false, maxLength: 70, unicode: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.T_Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        ProductImage = c.String(nullable: false, maxLength: 70, unicode: false),
                        ProductCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_ProductCategory", t => t.ProductCategory_Id)
                .Index(t => t.ProductCategory_Id);
            
            CreateTable(
                "dbo.T_ProductCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentCategoryId = c.Int(nullable: false),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.T_ShopOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        PaymentMethodId = c.Int(nullable: false),
                        ShippingAddressId = c.Int(nullable: false),
                        ShippingMethodId = c.Int(nullable: false),
                        OrderTotal = c.Int(nullable: false),
                        OrderStatusId = c.Int(nullable: false),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Adress", t => t.Address_Id)
                .ForeignKey("dbo.T_OrderStatus", t => t.OrderStatusId, cascadeDelete: true)
                .ForeignKey("dbo.T_ShippingMethod", t => t.ShippingMethodId, cascadeDelete: true)
                .Index(t => t.ShippingMethodId)
                .Index(t => t.OrderStatusId)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.T_OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.T_ShippingMethod",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.T_ProductConfiguration",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductItemId = c.Int(nullable: false),
                        VariationOptionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_ProductItem", t => t.ProductItemId, cascadeDelete: true)
                .ForeignKey("dbo.T_VariationOption", t => t.VariationOptionId, cascadeDelete: true)
                .Index(t => t.ProductItemId)
                .Index(t => t.VariationOptionId);
            
            CreateTable(
                "dbo.T_VariationOption",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VariationId = c.Int(nullable: false),
                        Value = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Variation", t => t.VariationId, cascadeDelete: true)
                .Index(t => t.VariationId);
            
            CreateTable(
                "dbo.T_Variation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 30),
                        ProductCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_ProductCategory", t => t.ProductCategory_Id)
                .Index(t => t.ProductCategory_Id);
            
            CreateTable(
                "dbo.T_PromotionCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        PromotionId = c.Int(nullable: false),
                        ProductCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_ProductCategory", t => t.ProductCategory_Id)
                .ForeignKey("dbo.T_Promotion", t => t.PromotionId, cascadeDelete: true)
                .Index(t => t.PromotionId)
                .Index(t => t.ProductCategory_Id);
            
            CreateTable(
                "dbo.T_Promotion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Description = c.String(nullable: false, maxLength: 50),
                        DiscountRate = c.Single(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        AdminId = c.Int(nullable: false),
                        AdminSite_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_AdminSite", t => t.AdminSite_Id)
                .Index(t => t.AdminSite_Id);
            
            CreateTable(
                "dbo.T_ShoppingCartItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CartId = c.Int(nullable: false),
                        ProductItemId = c.Int(nullable: false),
                        QTY = c.Int(nullable: false),
                        ShoppingCart_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_ProductItem", t => t.ProductItemId, cascadeDelete: true)
                .ForeignKey("dbo.T_ShoppingCart", t => t.ShoppingCart_Id)
                .Index(t => t.ProductItemId)
                .Index(t => t.ShoppingCart_Id);
            
            CreateTable(
                "dbo.T_ShoppingCart",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserSite_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_UserSite", t => t.UserSite_Id)
                .Index(t => t.UserSite_Id);
            
            CreateTable(
                "dbo.T_UserSite",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        Family = c.String(maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        Password = c.String(nullable: false, maxLength: 20, unicode: false),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.T_SupportSite",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        Family = c.String(maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        Password = c.String(nullable: false, maxLength: 20, unicode: false),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.T_UserAddress",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        IsDefault = c.Boolean(nullable: false),
                        UserSite_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_Adress", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.T_UserSite", t => t.UserSite_Id)
                .Index(t => t.AddressId)
                .Index(t => t.UserSite_Id);
            
            CreateTable(
                "dbo.T_UserPaymentMethod",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        OrderTotal = c.Int(nullable: false),
                        ShippingMethod = c.String(nullable: false, maxLength: 30),
                        BankName = c.String(nullable: false, maxLength: 30),
                        RegisterDate = c.DateTime(nullable: false),
                        ShopOrder_Id = c.Int(),
                        UserSite_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_ShopOrder", t => t.ShopOrder_Id)
                .ForeignKey("dbo.T_UserSite", t => t.UserSite_Id)
                .Index(t => t.ShopOrder_Id)
                .Index(t => t.UserSite_Id);
            
            CreateTable(
                "dbo.T_UserReview",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        OrderedProductId = c.Int(nullable: false),
                        RatingValue = c.String(nullable: false, maxLength: 5),
                        Comment = c.String(nullable: false, maxLength: 200),
                        RegisterDate = c.DateTime(nullable: false),
                        OrderLine_Id = c.Int(),
                        UserSite_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_OrderLine", t => t.OrderLine_Id)
                .ForeignKey("dbo.T_UserSite", t => t.UserSite_Id)
                .Index(t => t.OrderLine_Id)
                .Index(t => t.UserSite_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_UserReview", "UserSite_Id", "dbo.T_UserSite");
            DropForeignKey("dbo.T_UserReview", "OrderLine_Id", "dbo.T_OrderLine");
            DropForeignKey("dbo.T_UserPaymentMethod", "UserSite_Id", "dbo.T_UserSite");
            DropForeignKey("dbo.T_UserPaymentMethod", "ShopOrder_Id", "dbo.T_ShopOrder");
            DropForeignKey("dbo.T_UserAddress", "UserSite_Id", "dbo.T_UserSite");
            DropForeignKey("dbo.T_UserAddress", "AddressId", "dbo.T_Adress");
            DropForeignKey("dbo.T_SupportSite", "RoleId", "dbo.T_Role");
            DropForeignKey("dbo.T_ShoppingCartItem", "ShoppingCart_Id", "dbo.T_ShoppingCart");
            DropForeignKey("dbo.T_ShoppingCart", "UserSite_Id", "dbo.T_UserSite");
            DropForeignKey("dbo.T_UserSite", "RoleId", "dbo.T_Role");
            DropForeignKey("dbo.T_ShoppingCartItem", "ProductItemId", "dbo.T_ProductItem");
            DropForeignKey("dbo.T_PromotionCategory", "PromotionId", "dbo.T_Promotion");
            DropForeignKey("dbo.T_Promotion", "AdminSite_Id", "dbo.T_AdminSite");
            DropForeignKey("dbo.T_PromotionCategory", "ProductCategory_Id", "dbo.T_ProductCategory");
            DropForeignKey("dbo.T_ProductConfiguration", "VariationOptionId", "dbo.T_VariationOption");
            DropForeignKey("dbo.T_VariationOption", "VariationId", "dbo.T_Variation");
            DropForeignKey("dbo.T_Variation", "ProductCategory_Id", "dbo.T_ProductCategory");
            DropForeignKey("dbo.T_ProductConfiguration", "ProductItemId", "dbo.T_ProductItem");
            DropForeignKey("dbo.T_OrderLine", "ShopOrder_Id", "dbo.T_ShopOrder");
            DropForeignKey("dbo.T_ShopOrder", "ShippingMethodId", "dbo.T_ShippingMethod");
            DropForeignKey("dbo.T_ShopOrder", "OrderStatusId", "dbo.T_OrderStatus");
            DropForeignKey("dbo.T_ShopOrder", "Address_Id", "dbo.T_Adress");
            DropForeignKey("dbo.T_OrderLine", "ProductItemId", "dbo.T_ProductItem");
            DropForeignKey("dbo.T_ProductItem", "ProductId", "dbo.T_Product");
            DropForeignKey("dbo.T_Product", "ProductCategory_Id", "dbo.T_ProductCategory");
            DropForeignKey("dbo.T_AdminSite", "RoleId", "dbo.T_Role");
            DropIndex("dbo.T_UserReview", new[] { "UserSite_Id" });
            DropIndex("dbo.T_UserReview", new[] { "OrderLine_Id" });
            DropIndex("dbo.T_UserPaymentMethod", new[] { "UserSite_Id" });
            DropIndex("dbo.T_UserPaymentMethod", new[] { "ShopOrder_Id" });
            DropIndex("dbo.T_UserAddress", new[] { "UserSite_Id" });
            DropIndex("dbo.T_UserAddress", new[] { "AddressId" });
            DropIndex("dbo.T_SupportSite", new[] { "RoleId" });
            DropIndex("dbo.T_UserSite", new[] { "RoleId" });
            DropIndex("dbo.T_ShoppingCart", new[] { "UserSite_Id" });
            DropIndex("dbo.T_ShoppingCartItem", new[] { "ShoppingCart_Id" });
            DropIndex("dbo.T_ShoppingCartItem", new[] { "ProductItemId" });
            DropIndex("dbo.T_Promotion", new[] { "AdminSite_Id" });
            DropIndex("dbo.T_PromotionCategory", new[] { "ProductCategory_Id" });
            DropIndex("dbo.T_PromotionCategory", new[] { "PromotionId" });
            DropIndex("dbo.T_Variation", new[] { "ProductCategory_Id" });
            DropIndex("dbo.T_VariationOption", new[] { "VariationId" });
            DropIndex("dbo.T_ProductConfiguration", new[] { "VariationOptionId" });
            DropIndex("dbo.T_ProductConfiguration", new[] { "ProductItemId" });
            DropIndex("dbo.T_ShopOrder", new[] { "Address_Id" });
            DropIndex("dbo.T_ShopOrder", new[] { "OrderStatusId" });
            DropIndex("dbo.T_ShopOrder", new[] { "ShippingMethodId" });
            DropIndex("dbo.T_Product", new[] { "ProductCategory_Id" });
            DropIndex("dbo.T_ProductItem", new[] { "ProductId" });
            DropIndex("dbo.T_OrderLine", new[] { "ShopOrder_Id" });
            DropIndex("dbo.T_OrderLine", new[] { "ProductItemId" });
            DropIndex("dbo.T_AdminSite", new[] { "RoleId" });
            DropTable("dbo.T_UserReview");
            DropTable("dbo.T_UserPaymentMethod");
            DropTable("dbo.T_UserAddress");
            DropTable("dbo.T_SupportSite");
            DropTable("dbo.T_UserSite");
            DropTable("dbo.T_ShoppingCart");
            DropTable("dbo.T_ShoppingCartItem");
            DropTable("dbo.T_Promotion");
            DropTable("dbo.T_PromotionCategory");
            DropTable("dbo.T_Variation");
            DropTable("dbo.T_VariationOption");
            DropTable("dbo.T_ProductConfiguration");
            DropTable("dbo.T_ShippingMethod");
            DropTable("dbo.T_OrderStatus");
            DropTable("dbo.T_ShopOrder");
            DropTable("dbo.T_ProductCategory");
            DropTable("dbo.T_Product");
            DropTable("dbo.T_ProductItem");
            DropTable("dbo.T_OrderLine");
            DropTable("dbo.T_Role");
            DropTable("dbo.T_AdminSite");
            DropTable("dbo.T_Adress");
        }
    }
}
