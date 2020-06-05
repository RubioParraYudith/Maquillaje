namespace Maquillaje.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecliente : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "imgurl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "imgurl", c => c.String());
        }
    }
}
