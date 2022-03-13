using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class AddSeedDataInfosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Infos",
                columns: new[] { "Id", "Image", "Name", "Position", "Subtitle" },
                values: new object[] { 1, "testimonial-img-1.png", "Anna Barnes", "Florist", "Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus lingua." });

            migrationBuilder.InsertData(
                table: "Infos",
                columns: new[] { "Id", "Image", "Name", "Position", "Subtitle" },
                values: new object[] { 2, "testimonial-img-2.png", "Jasmine White", "Florist", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
