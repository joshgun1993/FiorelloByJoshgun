using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class AddSeedDataAboutsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Image", "Subtitle", "Title" },
                values: new object[] { 1, "h3-video-img.jpg", "Where flowers are our inspiration to create lasting memories. Whatever the occasion...", "<h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
