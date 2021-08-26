namespace GameFinderAgile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameGenres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        GenreName = c.String(nullable: false),
                        Description = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        GenreId = c.Int(nullable: false),
                        GameSystemId = c.Int(nullable: false),
                        ESRBRating = c.String(),
                        PlayerRating = c.Double(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Name)
                .ForeignKey("dbo.GameGenres", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("dbo.GameSystems", t => t.GameSystemId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.GameSystemId);
            
            CreateTable(
                "dbo.GameSystems",
                c => new
                    {
                        GameSystemId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        NumberOfGames = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameSystemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "GameSystemId", "dbo.GameSystems");
            DropForeignKey("dbo.Games", "GenreId", "dbo.GameGenres");
            DropIndex("dbo.Games", new[] { "GameSystemId" });
            DropIndex("dbo.Games", new[] { "GenreId" });
            DropTable("dbo.GameSystems");
            DropTable("dbo.Games");
            DropTable("dbo.GameGenres");
        }
    }
}
