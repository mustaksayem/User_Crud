namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB9 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Circulars");
            AddColumn("dbo.Users", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Circulars", "ID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Circulars", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Circulars");
            AlterColumn("dbo.Circulars", "ID", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Users", "Type");
            AddPrimaryKey("dbo.Circulars", "ID");
        }
    }
}
