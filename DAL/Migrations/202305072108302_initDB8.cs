namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Circulars", "PublishedDate", c => c.String(nullable: false));
            AlterColumn("dbo.Circulars", "LastDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Circulars", "LastDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Circulars", "PublishedDate", c => c.DateTime(nullable: false));
        }
    }
}
