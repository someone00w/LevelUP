using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LevelUP.Migrations
{
    /// <inheritdoc />
    public partial class ExternalUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cd2bcf0c-20db-474f-8407-5a6b159518bc", "cacfb15b-e47d-4731-a08a-ddf7a5d6b652" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
