namespace Vidyl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'545e9cd6-91d0-4121-96ce-e7b6829f135c', N'guest@vidyl.com', 0, N'AJ6l4SHfT8Ud6Xpm08fwdc2Kcn1F8VLT2wKNCf/oMhlRPXvYlL3Y0WrTUe+CGx9VOg==', N'ffe88904-63b1-4da1-af04-e02e38cc41f0', NULL, 0, 0, NULL, 1, 0, N'guest@vidyl.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'895ab07c-2c5e-40b3-bc3c-2f11b8cb4a72', N'admin@vidyl.com', 0, N'AGdL4Wy8Psvn7FNeeiZOcx6pF966yiqJH8NrL97bdhnOrjwvyb1nJLFxSmERk9jSow==', N'eb9ef008-1830-40d5-843b-e88bc75b5a1c', NULL, 0, 0, NULL, 1, 0, N'admin@vidyl.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd6841b95-ac32-4543-9086-f639394c889a', N'minakshichidrawar@gmail.com', 0, N'AOtIXhhG994IQCy1TaIvv+LyJ0tPwqtUe/ncWGdgvFwrt8au//rjRjcqVkWQ+CM9Sw==', N'e7b34285-041b-41d7-b69f-731da05e8b26', NULL, 0, 0, NULL, 1, 0, N'minakshichidrawar@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'326711bb-ac76-43a3-8c3f-3eff17525db8', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'895ab07c-2c5e-40b3-bc3c-2f11b8cb4a72', N'326711bb-ac76-43a3-8c3f-3eff17525db8')
");
        }

        public override void Down()
        {
        }
    }
}
