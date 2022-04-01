using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Location", "Name", "Type" },
                values: new object[] { 1, "Over there", "Costco", "Retail" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);
        }
    }
}
