using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevCreedUserManagments.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'c7ceb116-766a-44ef-a2ef-2b9fd69d4560', N'admin', N'ADMIN', N'admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAEAACcQAAAAEC9oZXLLqnsgF5orKdQrkgUSxbNKwmg1DlRapAnuf1H0peaMSUNvMyMzKsXxhk/bTQ==', N'UEXLN6RD7EBRDDJD3GWCOYMEITXD7UCC', N'0ece9e4d-be99-4bc0-9350-dc92da7ef73a', NULL, 0, 0, NULL, 1, 0, N'Mohamed', N'Mostaga', Null)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id ='c7ceb116-766a-44ef-a2ef-2b9fd69d4560'");
        }
    }
}
