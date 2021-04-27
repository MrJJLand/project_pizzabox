using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.pizzaboxsql.database.windows.net
{
    public partial class Context_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityID",
                table: "Pizzas");

            migrationBuilder.AddColumn<long>(
                name: "APizzaEntityID",
                table: "Topping",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SizeEntityID",
                table: "Pizzas",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "CrustEntityID1",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CrustEntityID2",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OrderEntityID",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SizeEntityID1",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SizeEntityID2",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ToppingEntityID",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "APizzaEntityID",
                table: "Order",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "AStoreEntityID",
                table: "Order",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "AStoreEntityID1",
                table: "Order",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CustomerEntityID1",
                table: "Order",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CustomerEntityID2",
                table: "Order",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CustomerID",
                table: "Customers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "EntityID", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Original", 0.0 },
                    { 2L, "Stuffed", 3.0 },
                    { 3L, "Pretzel", 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "EntityID", "APizzaEntityID", "AStoreEntityID", "AStoreEntityID1", "CustomerEntityID", "CustomerEntityID1", "CustomerEntityID2", "PizzaEntityID", "StoreEntityID" },
                values: new object[,]
                {
                    { 1L, null, null, null, null, null, null, null, null },
                    { 2L, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "EntityID", "name", "price" },
                values: new object[,]
                {
                    { 3L, "Large", 15.0 },
                    { 4L, "XL", 20.0 },
                    { 1L, "Small", 10.0 },
                    { 2L, "Medium", 13.0 }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "EntityID", "APizzaEntityID", "name", "price" },
                values: new object[,]
                {
                    { 11L, null, "Mushroom", 1.0 },
                    { 17L, null, "Scallions", 1.0 },
                    { 16L, null, "BBQ Sauce", 0.5 },
                    { 15L, null, "Garlic", 0.5 },
                    { 14L, null, "Shrimp", 2.0 },
                    { 13L, null, "Peppers", 1.0 },
                    { 12L, null, "Spinach", 1.0 },
                    { 10L, null, "Olives", 1.0 },
                    { 5L, null, "Bacon", 1.5 },
                    { 8L, null, "Tomato", 1.0 },
                    { 7L, null, "Buffalo Chicken", 1.5 },
                    { 6L, null, "Chicken", 1.5 },
                    { 18L, null, "Scallops", 2.0 },
                    { 4L, null, "Ham", 1.5 },
                    { 3L, null, "Sausage", 1.0 },
                    { 2L, null, "Extra Cheese", 1.0 },
                    { 1L, null, "Pepperoni", 1.0 },
                    { 9L, null, "Onion", 1.0 },
                    { 19L, null, "Pineapple", 1.5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Topping_APizzaEntityID",
                table: "Topping",
                column: "APizzaEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityID1",
                table: "Pizzas",
                column: "CrustEntityID1");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityID2",
                table: "Pizzas",
                column: "CrustEntityID2");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderEntityID",
                table: "Pizzas",
                column: "OrderEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeEntityID1",
                table: "Pizzas",
                column: "SizeEntityID1");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeEntityID2",
                table: "Pizzas",
                column: "SizeEntityID2");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_ToppingEntityID",
                table: "Pizzas",
                column: "ToppingEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_APizzaEntityID",
                table: "Order",
                column: "APizzaEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_AStoreEntityID",
                table: "Order",
                column: "AStoreEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_AStoreEntityID1",
                table: "Order",
                column: "AStoreEntityID1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerEntityID1",
                table: "Order",
                column: "CustomerEntityID1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerEntityID2",
                table: "Order",
                column: "CustomerEntityID2");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_CustomerEntityID1",
                table: "Order",
                column: "CustomerEntityID1",
                principalTable: "Customers",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_CustomerEntityID2",
                table: "Order",
                column: "CustomerEntityID2",
                principalTable: "Customers",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Pizzas_APizzaEntityID",
                table: "Order",
                column: "APizzaEntityID",
                principalTable: "Pizzas",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Stores_AStoreEntityID",
                table: "Order",
                column: "AStoreEntityID",
                principalTable: "Stores",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Stores_AStoreEntityID1",
                table: "Order",
                column: "AStoreEntityID1",
                principalTable: "Stores",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityID1",
                table: "Pizzas",
                column: "CrustEntityID1",
                principalTable: "Crust",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityID2",
                table: "Pizzas",
                column: "CrustEntityID2",
                principalTable: "Crust",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Order_OrderEntityID",
                table: "Pizzas",
                column: "OrderEntityID",
                principalTable: "Order",
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
                name: "FK_Pizzas_Sizes_SizeEntityID2",
                table: "Pizzas",
                column: "SizeEntityID2",
                principalTable: "Sizes",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Topping_ToppingEntityID",
                table: "Pizzas",
                column: "ToppingEntityID",
                principalTable: "Topping",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topping_Pizzas_APizzaEntityID",
                table: "Topping",
                column: "APizzaEntityID",
                principalTable: "Pizzas",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_CustomerEntityID1",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_CustomerEntityID2",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Pizzas_APizzaEntityID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stores_AStoreEntityID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stores_AStoreEntityID1",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityID1",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityID2",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Order_OrderEntityID",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityID",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityID1",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityID2",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Topping_ToppingEntityID",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Topping_Pizzas_APizzaEntityID",
                table: "Topping");

            migrationBuilder.DropIndex(
                name: "IX_Topping_APizzaEntityID",
                table: "Topping");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CrustEntityID1",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CrustEntityID2",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_OrderEntityID",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_SizeEntityID1",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_SizeEntityID2",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_ToppingEntityID",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Order_APizzaEntityID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_AStoreEntityID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_AStoreEntityID1",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerEntityID1",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerEntityID2",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 19L);

            migrationBuilder.DropColumn(
                name: "APizzaEntityID",
                table: "Topping");

            migrationBuilder.DropColumn(
                name: "CrustEntityID1",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "CrustEntityID2",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "OrderEntityID",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "SizeEntityID1",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "SizeEntityID2",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "ToppingEntityID",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "APizzaEntityID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "AStoreEntityID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "AStoreEntityID1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerEntityID1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerEntityID2",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Customers");

            migrationBuilder.AlterColumn<long>(
                name: "SizeEntityID",
                table: "Pizzas",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sizes_SizeEntityID",
                table: "Pizzas",
                column: "SizeEntityID",
                principalTable: "Sizes",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
