namespace DoctorWebForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [MedicalField], [AboutMe], [IsPrivate]) VALUES (N'cfb0eb11-bdd5-44cd-865e-6b6dd793199d', N'user1@forum.com', 0, N'ACU3RBBBv3dPiTtQRqKKfHk0LvTRnCV9l3+IbcxRVKLLTluj18FalGrA3DmP9/KXUg==', N'1aabb25f-b653-4c66-8408-defba58b3692', NULL, 0, 0, NULL, 1, 0, N'user1', N'User', N'1', N'Neuro', N'I''m user 1', 0)

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [MedicalField], [AboutMe], [IsPrivate]) VALUES (N'6c0b7e04-4222-49aa-9170-0a749ac294e9', N'user2@forum.com', 0, N'AO2HcLm3c5FdOlJ2jr3Azu7qfx3DkLbnP0kutoapgqq5nL0gMpBa7Dz7ypZTXZv1uA==', N'760c5ba5-a411-44ae-a999-fc4c775165cd', NULL, 0, 0, NULL, 1, 0, N'user2', N'User', N'2', N'Cardio', N'... and my account is private', 1)

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [MedicalField], [AboutMe], [IsPrivate]) VALUES (N'ff4060e4-77bb-4c0a-a4eb-31f158111579', N'admin@forum.com', 0, N'AF40Rl2er2m0HBs4QeAM/cTahgBX30+bGs0RPBt27vqFYmyjW6qSBFM3HYEEFzH7TQ==', N'053ecad3-6249-4142-9339-91ce70afcd69', NULL, 0, 0, NULL, 1, 0, N'admin', N'Admin', N'-', N'-', N'Abc123..', 0)

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'34d25cf3-e283-4dd4-9523-f643bda8411e', N'CanDeleteUsers')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ff4060e4-77bb-4c0a-a4eb-31f158111579', N'34d25cf3-e283-4dd4-9523-f643bda8411e')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
