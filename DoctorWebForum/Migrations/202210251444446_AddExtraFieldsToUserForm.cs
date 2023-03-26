namespace DoctorWebForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExtraFieldsToUserForm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "MedicalField", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "AboutMe", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AboutMe");
            DropColumn("dbo.AspNetUsers", "MedicalField");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
