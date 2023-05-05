namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HallStaffs",
                c => new
                    {
                        HSname = c.String(nullable: false, maxLength: 128),
                        HallStaffName = c.String(nullable: false, maxLength: 30),
                        HallStaffEmail = c.String(nullable: false),
                        HallStaffAddress = c.String(nullable: false),
                        HallStaffPhone = c.Int(nullable: false),
                        HallStaffGender = c.String(nullable: false),
                        HallStaffPassword = c.String(nullable: false, maxLength: 20),
                        HallStaffNid = c.Int(nullable: false),
                        Aname = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.HSname)
                .ForeignKey("dbo.Admins", t => t.Aname)
                .Index(t => t.Aname);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HallStaffs", "Aname", "dbo.Admins");
            DropIndex("dbo.HallStaffs", new[] { "Aname" });
            DropTable("dbo.HallStaffs");
        }
    }
}
