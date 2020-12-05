namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0d7bddda-a714-4742-a6f7-871685eb8f41', N'admin@vidly.com', 0, N'AFG8ict5MwdDJkqcT33vdjFDIbzSAb/W8OaYg3+iymPeAC09rjOx8SZn+XukVo7Mnw==', N'8090ff09-e5b3-4be6-ad4c-5087b8fbef51', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b8a36a42-a1ba-4e1c-aaf6-b6e6fcfd8344', N'guest@vidly.com', 0, N'AGEYW0jYDPzLz4KngoMgYxiY8+4CkGnNr9H+VGkEFOOCJu2L4KKPhu/2ByZY2+IHxA==', N'a8afb76d-410f-4e56-a867-2d01327ad076', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c7ddd090-48c5-47b4-ac38-a2a77c512f89', N'StoreManager')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0d7bddda-a714-4742-a6f7-871685eb8f41', N'c7ddd090-48c5-47b4-ac38-a2a77c512f89')
");
        }
        
        public override void Down()
        {
        }
    }
}
