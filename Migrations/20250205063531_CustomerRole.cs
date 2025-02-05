using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LevelUP.Migrations
{
    /// <inheritdoc />
    public partial class CustomerRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cd2bcf0c-20db-474f-8407-5a6b159518bc", null, "Customer", "CUSTOMER"}
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
