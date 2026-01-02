namespace BookStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AuthorId = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Nationality = c.String(),
                        Bio = c.String(),
                        Email = c.String(),
                        Affiliation = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Year = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Genre = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                        GenreId = c.Int(nullable: false),
                        Director = c.String(),
                        Writer = c.String(),
                        Producer = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Rating = c.Byte(nullable: false),
                        TrailerURI = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        UniqueKey = c.Guid(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        StockId = c.Int(nullable: false),
                        RentalDate = c.DateTime(nullable: false),
                        ReturnedDate = c.DateTime(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Stocks", t => t.StockId, cascadeDelete: true)
                .Index(t => t.StockId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "StockId", "dbo.Stocks");
            DropForeignKey("dbo.Stocks", "BookId", "dbo.Books");
            DropIndex("dbo.Rentals", new[] { "StockId" });
            DropIndex("dbo.Stocks", new[] { "BookId" });
            DropTable("dbo.Rentals");
            DropTable("dbo.Stocks");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
