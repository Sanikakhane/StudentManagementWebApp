using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementWebApp.Migrations
{
    /// <inheritdoc />
    public partial class dataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Marks", "Name" },
                values: new object[,]
                {
                    { 1, 20, "[85,90,78]", "John" },
                    { 2, 22, "[92,88,94]", "Alice" },
                    { 3, 21, "[75,80,70]", "Bob" },
                    { 4, 23, "[65,70,80]", "Charlie" },
                    { 5, 24, "[88,90,85]", "David" },
                    { 6, 19, "[78,82,80]", "Eve" },
                    { 7, 20, "[92,95,91]", "Frank" },
                    { 8, 22, "[70,72,68]", "Grace" },
                    { 9, 21, "[90,88,85]", "Hannah" },
                    { 10, 23, "[80,85,78]", "Ivy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
