using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class AddSeedDataAboutListsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AboutLists",
                columns: new[] { "Id", "Image", "Title" },
                values: new object[] { 1, "h1-custom-icon.png", "Hand picked just for you." });

            migrationBuilder.InsertData(
                table: "AboutLists",
                columns: new[] { "Id", "Image", "Title" },
                values: new object[] { 2, "h1-custom-icon.png", "Unique flower arrangements" });

            migrationBuilder.InsertData(
                table: "AboutLists",
                columns: new[] { "Id", "Image", "Title" },
                values: new object[] { 3, "h1-custom-icon.png", "Best way to say you care." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AboutLists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AboutLists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AboutLists",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
