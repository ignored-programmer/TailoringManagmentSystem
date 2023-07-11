namespace TMS.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clothes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClothName = c.String(nullable: false),
                        ClothCode = c.String(nullable: false),
                        ClothPic = c.String(),
                        Inventory = c.String(),
                        AvailableSize = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OrderCode = c.Int(nullable: false),
                        CustomerFullName = c.String(nullable: false, maxLength: 50),
                        MobileCustomer = c.String(nullable: false, maxLength: 12),
                        Status = c.String(nullable: false, maxLength: 50),
                        PaymentMethod = c.String(nullable: false, maxLength: 50),
                        ReceivedMoney = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        CustomerId = c.Long(nullable: false),
                        ClothId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clothes", t => t.ClothId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ClothId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 20),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Address = c.String(maxLength: 150),
                        PostalCode = c.String(maxLength: 20),
                        IsActive = c.Boolean(nullable: false),
                        BalaRoPant = c.String(),
                        GhadZanooPant = c.String(),
                        GhadKamelPant = c.String(),
                        KamarPant = c.String(),
                        BasanPant = c.String(),
                        RanPant = c.String(),
                        ZanooPant = c.String(),
                        DampaPant = c.String(),
                        SarShaneShirt = c.String(),
                        GhadAstinShirt = c.String(),
                        GhadPirahanShirt = c.String(),
                        SineShirt = c.String(),
                        KamarShirt = c.String(),
                        YagheShirt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 12),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "ClothId", "dbo.Clothes");
            DropIndex("dbo.Orders", new[] { "ClothId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.Users");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.Clothes");
        }
    }
}
