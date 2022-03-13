using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class AddSeedDataExpertsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "Image", "Name", "Position" },
                values: new object[,]
                {
                    { 1, "h3-team-img-1.png", "CRYSTAL BROOKS", "Florist" },
                    { 2, "h3-team-img-2.png", "SHIRLEY HARRIS", "Manager" },
                    { 3, "h3-team-img-3.png", "BEVERLY CLARK", "Florist" },
                    { 4, "h3-team-img-4.png", "AMANDA WATKINS", "Florist" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
