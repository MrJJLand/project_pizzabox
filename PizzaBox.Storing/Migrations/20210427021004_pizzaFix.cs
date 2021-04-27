using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class pizzaFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crusts_CrustEntityID",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crusts_CrustEntityID1",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityID",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityID1",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Pizzas_APizzaEntityID",
                table: "Toppings");

            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Pizzas_APizzaEntityID1",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_APizzaEntityID",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_APizzaEntityID1",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CrustEntityID",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CrustEntityID1",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_SizeEntityID",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_SizeEntityID1",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "APizzaEntityID",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "APizzaEntityID1",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "CrustEntityID",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "CrustEntityID1",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "SizeEntityID",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "SizeEntityID1",
                table: "Pizzas");

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "Pizzas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "EntityID", "Discriminator", "price" },
                values: new object[,]
                {
                    { 1L, "Custom", 0.0 },
                    { 2L, "Hawaiian", 0.0 },
                    { 3L, "Meatlovers", 0.0 },
                    { 4L, "Veggie", 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 4L);

            migrationBuilder.DropColumn(
                name: "price",
                table: "Pizzas");

            migrationBuilder.AddColumn<long>(
                name: "APizzaEntityID",
                table: "Toppings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "APizzaEntityID1",
                table: "Toppings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CrustEntityID",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CrustEntityID1",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SizeEntityID",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SizeEntityID1",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_APizzaEntityID",
                table: "Toppings",
                column: "APizzaEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_APizzaEntityID1",
                table: "Toppings",
                column: "APizzaEntityID1");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityID",
                table: "Pizzas",
                column: "CrustEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityID1",
                table: "Pizzas",
                column: "CrustEntityID1");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeEntityID",
                table: "Pizzas",
                column: "SizeEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeEntityID1",
                table: "Pizzas",
                column: "SizeEntityID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crusts_CrustEntityID",
                table: "Pizzas",
                column: "CrustEntityID",
                principalTable: "Crusts",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crusts_CrustEntityID1",
                table: "Pizzas",
                column: "CrustEntityID1",
                principalTable: "Crusts",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityID",
                table: "Pizzas",
                column: "SizeEntityID",
                principalTable: "Sizes",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityID1",
                table: "Pizzas",
                column: "SizeEntityID1",
                principalTable: "Sizes",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_Pizzas_APizzaEntityID",
                table: "Toppings",
                column: "APizzaEntityID",
                principalTable: "Pizzas",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_Pizzas_APizzaEntityID1",
                table: "Toppings",
                column: "APizzaEntityID1",
                principalTable: "Pizzas",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
