using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessAPI.Migrations
{
    public partial class MoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 2, "Over there", "Mcdonalds", "Fast food" },
                    { 3, "Over there", "Walmart", "Retail" },
                    { 4, "Over there", "Walgreens", "Pharmacy" },
                    { 5, "Over there", "Hardees", "Fast food" },
                    { 6, "Over there", "Armani", "Luxury" },
                    { 7, "Over there", "ToysRus", "Toys" },
                    { 8, "Over there", "Best Buy", "Electronics" },
                    { 9, "Over there", "Lil Caesars", "Pizza" },
                    { 10, "Over there", "Frank's", "Sandwiches" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 10);
        }
    }
}
