using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevCreedUserManagments.Data.Migrations
{
    public partial class AssignAdminToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into [security].[UserRoles] (UserId , RoleId) SELECT 'c7ceb116-766a-44ef-a2ef-2b9fd69d4560', Id FROM [security].[Roles] ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE from [security].[UserRoles] Where UserId= 'c7ceb116-766a-44ef-a2ef-2b9fd69d4560'");
        }
    }
}
