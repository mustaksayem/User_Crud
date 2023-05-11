namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Circulars",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        PublishedDate = c.DateTime(nullable: false),
                        LastDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Circulars");
        }
    }
}
