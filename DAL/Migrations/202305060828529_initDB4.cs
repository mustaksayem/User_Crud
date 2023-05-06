namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "AdminType", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "AdminType");
        }
    }
}
