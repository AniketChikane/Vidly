namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e0fc64ee-b0a4-4b2a-8983-2f667511471b', N'Aniketchikane.ar1234@gmail.com', 0, N'AMQfbVlwYCUwhT0W1QASR1GzI1eRrRSfCkMhZqN3PKHk0N06aHwyGPfmGaVe5KtrxQ==', N'2082c106-111e-444e-b9ae-e3751d2bc53d', NULL, 0, 0, NULL, 1, 0, N'Aniketchikane.ar1234@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f627a74c-d7bd-4dad-bbd8-e0a7982e9be3', N'admin@vidly.com', 0, N'AAwLKRJ3XPKN+fQJo79rxYghIHmFojpUqxYyba8LkHMCMBlRDiZ+BiuAiwA48q6Iqw==', N'0d9fb7c7-82c2-4487-ba4e-7dba817a291a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a50561be-7245-49ff-97df-fc71b98c03af', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f627a74c-d7bd-4dad-bbd8-e0a7982e9be3', N'a50561be-7245-49ff-97df-fc71b98c03af')
            ");
        }

        public override void Down()
        {
        }
    }
}
