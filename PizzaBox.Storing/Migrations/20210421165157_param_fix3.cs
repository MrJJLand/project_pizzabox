using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class param_fix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "EntityID", "name" },
                values: new object[] { 1L, "Ashley Johnson" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityID", "Discriminator", "name" },
                values: new object[] { 1L, "ChicagoStore", "Main St. PizzaBox" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityID", "Discriminator", "name" },
                values: new object[] { 2L, "NewYorkStore", "South James St. PizzaBox" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 2L);
        }
    }
}
