using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class pizzaPriceUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "Pizzas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "Pizzas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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
    }
}
