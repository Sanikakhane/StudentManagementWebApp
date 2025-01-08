using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementWebApp.Migrations
{
    /// <inheritdoc />
    public partial class rowAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Marks", "Name" },
                values: new object[] { 11, 23, "[80,85,78]", "Ivy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
