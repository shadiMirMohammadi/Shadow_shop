namespace Shadow_shop.ModelsLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.T_ProductCategory", "ParentCategoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.T_ProductCategory", "ParentCategoryName", c => c.String(maxLength: 50));
        }
    }
}
