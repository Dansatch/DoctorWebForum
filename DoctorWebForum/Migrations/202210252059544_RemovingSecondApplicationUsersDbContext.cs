namespace DoctorWebForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingSecondApplicationUsersDbContext : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.RegisterViewModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RegisterViewModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MedicalField = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 100),
                        ConfirmPassword = c.String(),
                        AboutMe = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
