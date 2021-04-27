using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class pizzaFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "price",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "price",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 4L,
                column: "price",
                value: 15.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 4L,
                column: "price",
                value: 0.0);
        }
    }
}
