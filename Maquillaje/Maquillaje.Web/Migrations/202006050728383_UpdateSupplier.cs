namespace Maquillaje.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSupplier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "Product_Id", c => c.Int());
            CreateIndex("dbo.Suppliers", "Product_Id");
            AddForeignKey("dbo.Suppliers", "Product_Id", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Suppliers", "Product_Id", "dbo.Products");
            DropIndex("dbo.Suppliers", new[] { "Product_Id" });
            DropColumn("dbo.Suppliers", "Product_Id");
        }
    }
}
