namespace MarketOtomasyon.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CategoryName = c.String(nullable: false, maxLength: 120),
                        Description = c.String(),
                        KdvRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 100),
                        Barcode = c.String(),
                        BuyPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockQuantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoryId = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Id2 = c.Guid(nullable: false),
                        ProductName = c.String(maxLength: 50),
                        Type = c.String(maxLength: 50),
                        PackageQuantity = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.Id2 })
                .ForeignKey("dbo.Order", t => t.Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Id2, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.Id2);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.Int(nullable: false),
                        Barcode = c.String(),
                        ProductId = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.SaleDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Id2 = c.Guid(nullable: false),
                        ProductName = c.String(),
                        Quantity = c.Int(nullable: false),
                        PaymentTypes = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.Id2 })
                .ForeignKey("dbo.Products", t => t.Id2, cascadeDelete: true)
                .ForeignKey("dbo.Sales", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.Id2);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SaleDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleDetails", "Id", "dbo.Sales");
            DropForeignKey("dbo.SaleDetails", "Id2", "dbo.Products");
            DropForeignKey("dbo.Packages", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "Id2", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "Id", "dbo.Order");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.SaleDetails", new[] { "Id2" });
            DropIndex("dbo.SaleDetails", new[] { "Id" });
            DropIndex("dbo.Packages", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "Id2" });
            DropIndex("dbo.OrderDetails", new[] { "Id" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Sales");
            DropTable("dbo.SaleDetails");
            DropTable("dbo.Packages");
            DropTable("dbo.Order");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
