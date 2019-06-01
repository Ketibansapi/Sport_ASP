namespace SportTransfer4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'19131676-46e0-4fb9-afbb-d5019afefdb3', N'guest@sporttransfer.com', 0, N'AIubwo6ACBuB6RNmt6eLg8WZ/dUJ+dxiikuMJC8QRAmydMWNPmzR5rs71n3BGORB7A==', N'a646423a-977f-40da-b13d-f2ae552203e7', NULL, 0, 0, NULL, 1, 0, N'guest@sporttransfer.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9acc3a23-1d90-4e01-889e-3aab5bddebf6', N'admin@sporttransfers.com', 0, N'ANifxTWGKR9kQV9Kho1YXKTZ8C6SNTLvf7GHty5GBpNR76mJLT83zixiQ0zqYDTL0g==', N'a321939d-43c2-40af-add9-575bd8f69943', NULL, 0, 0, NULL, 1, 0, N'admin@sporttransfers.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'58613d15-9098-44f7-b2fa-411c3ad36ed0', N'CanManageTransfers')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9acc3a23-1d90-4e01-889e-3aab5bddebf6', N'58613d15-9098-44f7-b2fa-411c3ad36ed0')


");
        }
        
        public override void Down()
        {
        }
    }
}
