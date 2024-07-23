namespace Shadow_shop.ModelsLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.T_ProductCategory", "ParentCategoryName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.T_ProductCategory", "ParentCategoryName");
        }
    }
}
