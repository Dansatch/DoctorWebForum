namespace DoctorWebForum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingForumTables : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                /*NOTE: this script creates all the necessary tables, but it DOES NOT create any database*/

				CREATE TABLE ForumAdministrators (
					UserID int NOT NULL PRIMARY KEY
				)
				GO

				CREATE TABLE ForumGroups (
					GroupID int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
					GroupName nvarchar (50) NOT NULL,
					OrderByNumber int NOT NULL DEFAULT 0
				)
				GO

				CREATE TABLE Forums (
					ForumID int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
					Title nvarchar (50)  NOT NULL ,
					[Description] nvarchar (255) NOT NULL ,
					Premoderated bit NOT NULL DEFAULT 0,
					GroupID int NOT NULL,
					MembersOnly bit NOT NULL DEFAULT 0,
					OrderByNumber int NOT NULL DEFAULT 0,
					RestrictTopicCreation bit NOT NULL DEFAULT 0,
					IconFile nvarchar(50) NULL
				)
				GO

				CREATE TABLE ForumSubforums(
					ParentForumID int NOT NULL,
					SubForumID int NOT NULL
				)
				GO

				CREATE TABLE ForumMessages (
					MessageID int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
					TopicID int NOT NULL ,
					UserID int NOT NULL ,
					Body ntext NOT NULL ,
					CreationDate datetime NOT NULL ,
					Visible bit NOT NULL DEFAULT 1,
					IPAddress varchar(50),
					Rating int NOT NULL DEFAULT 0,
					AcceptedAnswer bit NOT NULL DEFAULT 0
				)
				GO

				CREATE TABLE ForumModerators (
					UserID int NOT NULL ,
					ForumID int NOT NULL 
				)
				GO

				CREATE TABLE ForumSubscriptions (
					UserID int NOT NULL ,
					TopicID int NOT NULL 
				)
				GO

				CREATE TABLE ForumComplaints (
					UserID int NOT NULL ,
					MessageID int NOT NULL,
					ComplainText ntext NOT NULL
				)
				GO

				CREATE TABLE ForumGroupPermissions (
					ForumID int NOT NULL ,
					GroupID int NOT NULL ,
					AllowReading bit NOT NULL ,
					AllowPosting bit NOT NULL
				)
				GO

				CREATE TABLE ForumUserGroups (
					GroupID int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
					Title nvarchar (50) NOT NULL
				)
				GO

				CREATE TABLE ForumUsersInGroup (
					GroupID int NOT NULL ,
					UserID int NOT NULL
				)
				GO

				CREATE TABLE ForumNewTopicSubscriptions (
					UserID int NOT NULL ,
					ForumID int NOT NULL 
				)
				GO

				CREATE TABLE ForumNewForumMsgSubscriptions (
					UserID int NOT NULL ,
					ForumID int NOT NULL 
				)
				GO

				CREATE TABLE ForumTopics (
					TopicID int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
					ForumID int NOT NULL ,
					UserID int NOT NULL ,
					[Subject] nvarchar (255) NOT NULL ,
					Visible bit NOT NULL ,
					LastMessageID int NOT NULL DEFAULT 0,
					IsSticky int NOT NULL DEFAULT 0,
					IsClosed bit NOT NULL DEFAULT 0,
					ViewsCount int NOT NULL DEFAULT 0,
					RepliesCount int NOT NULL DEFAULT 0
				)
				GO

				CREATE TABLE ForumUsers (
					UserID int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
					UserName nvarchar (50) NOT NULL ,
					FirstName nvarchar(100) NULL,
					LastName nvarchar(100) NULL,
					Email nvarchar (50) NOT NULL ,
					[Password] nvarchar (50) NOT NULL ,
					Homepage nvarchar (255) NULL ,
					Interests nvarchar (255) NULL ,
					PostsCount int NOT NULL DEFAULT 0,
					RegistrationDate datetime NOT NULL DEFAULT getdate(),
					[Disabled] bit NOT NULL DEFAULT 0,
					ActivationCode nvarchar(50) NOT NULL DEFAULT '',
					AvatarFileName nvarchar(255) NULL,
					Signature nvarchar(1000) NULL,
					LastLogonDate datetime NULL,
					ReputationCache int NOT NULL DEFAULT 0,
					OpenIdUserName nvarchar(255) NULL,
					HidePresence bit NOT NULL DEFAULT 0,
					UseGravatar bit NOT NULL DEFAULT 1,
					TwitterUserName varchar(255) NULL,
					FacebookID varchar(255) NULL
				)
				GO

				CREATE TABLE ForumPersonalMessages (
					MessageID int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
					FromUserID int NOT NULL ,
					ToUserID int NOT NULL ,
					Body ntext NOT NULL ,
					CreationDate datetime NOT NULL ,
					New bit NOT NULL DEFAULT 1 ,
					HiddenBySender bit NOT NULL DEFAULT 0 ,
					HiddenByRecipient bit NOT NULL DEFAULT 0
				)
				GO

				CREATE TABLE ForumUploadedFiles (
					FileID int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
					FileName nvarchar (255)  NOT NULL ,
					MessageID int NOT NULL ,
					UserID int NOT NULL 
				)
				GO

				CREATE TABLE ForumUploadedPersonalFiles (
					FileID int IDENTITY (1, 1) NOT NULL PRIMARY KEY,
					FileName nvarchar (255)  NOT NULL ,
					MessageID int NOT NULL ,
					UserID int NOT NULL 
				)
				GO

				CREATE TABLE ForumPolls (
					PollID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
					TopicID int NOT NULL,
					Question nvarchar(255) NOT NULL
				)
				GO

				CREATE TABLE ForumPollOptions (
					OptionID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
					PollID int NOT NULL,
					OptionText nvarchar(255) NOT NULL
				)
				GO

				CREATE TABLE ForumPollAnswers (
					UserID int NOT NULL,
					OptionID int NOT NULL
				)
				GO

				CREATE TABLE ForumMessageRating (
					MessageID int NOT NULL,
					VoterUserID int NOT NULL,
					Score int NOT NULL
				)
				GO

				CREATE TABLE ForumSettings (
					LastDigestSentDate datetime NULL
				)
				GO

				CREATE TABLE ForumAchievements (
					AchievementID int NOT NULL,
					UserID int NOT NULL ,
					DateCreated DateTime NOT NULL,
					TimesAchieved int NOT NULL
				)
				GO

				/*adding complex keys*/

				ALTER TABLE ForumAchievements ADD 
					PRIMARY KEY 
					(
						AchievementID,
						UserID
					)
				GO

				ALTER TABLE ForumMessageRating ADD 
					PRIMARY KEY 
					(
						MessageID,
						VoterUserID
					)
				GO

				ALTER TABLE ForumPollAnswers ADD 
					PRIMARY KEY 
					(
						UserID,
						OptionID
					)
				GO

				ALTER TABLE ForumModerators ADD 
					PRIMARY KEY 
					(
						UserID,
						ForumID
					)
				GO

				ALTER TABLE ForumSubscriptions ADD 
					PRIMARY KEY 
					(
						UserID,
						TopicID
					)
				GO

				ALTER TABLE ForumNewTopicSubscriptions ADD 
					PRIMARY KEY 
					(
						UserID,
						ForumID
					)
				GO

				ALTER TABLE ForumNewForumMsgSubscriptions ADD 
					PRIMARY KEY 
					(
						UserID,
						ForumID
					)
				GO

				ALTER TABLE ForumGroupPermissions ADD 
					PRIMARY KEY 
					(
						ForumID,
						GroupID
					)
				GO

				ALTER TABLE ForumUsersInGroup ADD 
					PRIMARY KEY 
					(
						UserID,
						GroupID
					)
				GO

				ALTER TABLE ForumSubforums ADD 
					PRIMARY KEY 
					(
						ParentForumID,
						SubForumID
					)
				GO

				INSERT INTO ForumUsers (UserName, Email, Password)
				VALUES ('admin', 'admin@forum.com', '551DB2B0CD87B44CF3702690805545DE')

				INSERT INTO ForumAdministrators (UserID)
				VALUES (1)

				CREATE TABLE ForumConfig (
					CfgKey nvarchar(255) NOT NULL PRIMARY KEY,
					CfgValue ntext NOT NULL DEFAULT ''
				)
				GO
			");
        }
        
        public override void Down()
        {
        }
    }
}
