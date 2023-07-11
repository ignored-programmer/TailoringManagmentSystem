namespace TMS.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clothes", "ClothPic");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clothes", "ClothPic", c => c.String());
        }
    }
}
