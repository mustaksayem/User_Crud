namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.String(nullable: false, maxLength: 128),
                        MovieTitle = c.String(nullable: false, maxLength: 30),
                        MovieDescription = c.String(nullable: false),
                        MovieDuration = c.String(nullable: false),
                        MoviePicture = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Uname = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false, maxLength: 30),
                        UserEmail = c.String(nullable: false),
                        UserAddress = c.String(nullable: false),
                        UserPhone = c.Int(nullable: false),
                        UserGender = c.String(nullable: false),
                        UserPassword = c.String(nullable: false, maxLength: 20),
                        MovieId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Uname)
                .ForeignKey("dbo.Movies", t => t.MovieId)
                .Index(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "MovieId", "dbo.Movies");
            DropIndex("dbo.Users", new[] { "MovieId" });
            DropTable("dbo.Users");
            DropTable("dbo.Movies");
        }
    }
}
