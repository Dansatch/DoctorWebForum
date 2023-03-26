namespace DoctorWebForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingIsPrivateFieldToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsPrivate", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsPrivate");
        }
    }
}
