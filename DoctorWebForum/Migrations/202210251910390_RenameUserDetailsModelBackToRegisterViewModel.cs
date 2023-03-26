namespace DoctorWebForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameUserDetailsModelBackToRegisterViewModel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserDetailsModels", newName: "RegisterViewModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.RegisterViewModels", newName: "UserDetailsModels");
        }
    }
}
