using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class param_fix4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "EntityID", "name" },
                values: new object[] { 3L, "Ashley Johnson" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 3L);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "EntityID", "name" },
                values: new object[] { 1L, "Ashley Johnson" });
        }
    }
}
