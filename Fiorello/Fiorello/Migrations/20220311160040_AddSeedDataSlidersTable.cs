using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class AddSeedDataSlidersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Image" },
                values: new object[] { 1, "h3-slider-background.jpg" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Image" },
                values: new object[] { 2, "h3-slider-background-2.jpg" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Image" },
                values: new object[] { 3, "h3-slider-background-3.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
