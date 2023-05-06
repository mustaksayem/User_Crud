namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Type", c => c.String(nullable: false));
            DropColumn("dbo.Admins", "AdminType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "AdminType", c => c.String(nullable: false));
            DropColumn("dbo.Admins", "Type");
        }
    }
}
