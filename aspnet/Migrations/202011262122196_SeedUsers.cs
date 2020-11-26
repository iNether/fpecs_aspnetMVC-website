namespace aspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'81512d80-9c1b-4d76-835e-377d1cdfa76e', N'moviesmanager@a.com', 0, N'ABErAVxrYmtOWYxA+lXVdpUQkNZX7HowEBLmTwJh3OLNE1CTAvPUi8mKzpDk2vjBEw==', N'b82d594e-0a35-4228-97fc-fba09885c2d8', NULL, 0, 0, NULL, 1, 0, N'moviesmanager@a.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'831382cd-22bc-47a2-8155-1d4104dd7ea1', N'guest@a.com', 0, N'AEZYFt1BKfbhM1qaJ6ByMjtbI9Y+7XXahaGka3A2/mQkbOywzN/gCpjzYhiJIQNHdQ==', N'5c59c2d0-6295-4335-91b5-6c837a5f31d4', NULL, 0, 0, NULL, 1, 0, N'guest@a.com')
            
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e8fae14f-a14c-400a-bab9-c3d8e4dd24e1', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'81512d80-9c1b-4d76-835e-377d1cdfa76e', N'e8fae14f-a14c-400a-bab9-c3d8e4dd24e1')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
