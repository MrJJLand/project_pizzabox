using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.pizzaboxsql.database.windows.net
{
    public partial class TableExecution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_CustomerEntityID",
                table: "Order");

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
                name: "FK_Order_Pizzas_PizzaEntityID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stores_AStoreEntityID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stores_AStoreEntityID1",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stores_StoreEntityID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityID",
                table: "Pizzas");

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
                name: "FK_Pizzas_Sizes_SizeEntityID2",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Topping_ToppingEntityID",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Topping_Pizzas_APizzaEntityID",
                table: "Topping");

            migrationBuilder.DropTable(
                name: "APizzaTopping");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CrustEntityID2",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_OrderEntityID",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_SizeEntityID2",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_ToppingEntityID",
                table: "Pizzas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topping",
                table: "Topping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crust",
                table: "Crust");

            migrationBuilder.DropColumn(
                name: "CrustEntityID2",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "OrderEntityID",
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

            migrationBuilder.RenameTable(
                name: "Topping",
                newName: "Toppings");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Crust",
                newName: "Crusts");

            migrationBuilder.RenameIndex(
                name: "IX_Topping_APizzaEntityID",
                table: "Toppings",
                newName: "IX_Toppings_APizzaEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_StoreEntityID",
                table: "Orders",
                newName: "IX_Orders_StoreEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_PizzaEntityID",
                table: "Orders",
                newName: "IX_Orders_PizzaEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomerEntityID",
                table: "Orders",
                newName: "IX_Orders_CustomerEntityID");

            migrationBuilder.AddColumn<long>(
                name: "APizzaEntityID1",
                table: "Toppings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings",
                column: "EntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "EntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crusts",
                table: "Crusts",
                column: "EntityID");

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityID",
                keyValue: 2L,
                columns: new[] { "name", "price" },
                values: new object[] { "Pretzel", 1.5 });

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "name",
                value: "Thin");

            migrationBuilder.InsertData(
                table: "Crusts",
                columns: new[] { "EntityID", "name", "price" },
                values: new object[,]
                {
                    { 4L, "Deep Dish", 2.0 },
                    { 5L, "Gluten Free", 2.0 },
                    { 6L, "Stuffed", 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "EntityID", "CustomerID", "name" },
                values: new object[,]
                {
                    { 6L, 0L, "Ronald Rump" },
                    { 7L, 0L, "Slope Flinton" },
                    { 8L, 0L, "Just Monika" },
                    { 9L, 0L, "Plague Doctor" },
                    { 10L, 0L, "Darth Plagueis" }
                });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 1L,
                columns: new[] { "name", "price" },
                values: new object[] { "Mozzerella", 0.0 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 2L,
                columns: new[] { "name", "price" },
                values: new object[] { "Pizza Sauce", 0.0 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 3L,
                columns: new[] { "name", "price" },
                values: new object[] { "BBQ Sauce", 0.5 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 4L,
                columns: new[] { "name", "price" },
                values: new object[] { "Buffalo Sauce", 0.5 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 5L,
                columns: new[] { "name", "price" },
                values: new object[] { "Garlic", 0.5 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 6L,
                columns: new[] { "name", "price" },
                values: new object[] { "Ranch", 0.5 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 7L,
                columns: new[] { "name", "price" },
                values: new object[] { "Extra Cheese", 1.0 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 8L,
                column: "name",
                value: "Mushroom");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 9L,
                column: "name",
                value: "Olives");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 10L,
                column: "name",
                value: "Onion");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 11L,
                column: "name",
                value: "Pepperoni");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 12L,
                column: "name",
                value: "Peppers");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 13L,
                column: "name",
                value: "Sausage");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 14L,
                columns: new[] { "name", "price" },
                values: new object[] { "Scallions", 1.0 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 15L,
                columns: new[] { "name", "price" },
                values: new object[] { "Spinach", 1.0 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 16L,
                columns: new[] { "name", "price" },
                values: new object[] { "Tomato", 1.0 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 17L,
                columns: new[] { "name", "price" },
                values: new object[] { "Anchovies", 1.5 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 18L,
                columns: new[] { "name", "price" },
                values: new object[] { "Bacon", 1.5 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 19L,
                column: "name",
                value: "Chicken");

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "EntityID", "APizzaEntityID", "APizzaEntityID1", "name", "price" },
                values: new object[,]
                {
                    { 20L, null, null, "Ham", 1.5 },
                    { 21L, null, null, "Pineapple", 1.5 },
                    { 23L, null, null, "Shrimp", 2.0 },
                    { 22L, null, null, "Scallops", 2.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_APizzaEntityID1",
                table: "Toppings",
                column: "APizzaEntityID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerEntityID",
                table: "Orders",
                column: "CustomerEntityID",
                principalTable: "Customers",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Pizzas_PizzaEntityID",
                table: "Orders",
                column: "PizzaEntityID",
                principalTable: "Pizzas",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreEntityID",
                table: "Orders",
                column: "StoreEntityID",
                principalTable: "Stores",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerEntityID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pizzas_PizzaEntityID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreEntityID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crusts_CrustEntityID",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crusts_CrustEntityID1",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Pizzas_APizzaEntityID",
                table: "Toppings");

            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Pizzas_APizzaEntityID1",
                table: "Toppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_APizzaEntityID1",
                table: "Toppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crusts",
                table: "Crusts");

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "EntityID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "EntityID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "EntityID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 23L);

            migrationBuilder.DropColumn(
                name: "APizzaEntityID1",
                table: "Toppings");

            migrationBuilder.RenameTable(
                name: "Toppings",
                newName: "Topping");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Crusts",
                newName: "Crust");

            migrationBuilder.RenameIndex(
                name: "IX_Toppings_APizzaEntityID",
                table: "Topping",
                newName: "IX_Topping_APizzaEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_StoreEntityID",
                table: "Order",
                newName: "IX_Order_StoreEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PizzaEntityID",
                table: "Order",
                newName: "IX_Order_PizzaEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerEntityID",
                table: "Order",
                newName: "IX_Order_CustomerEntityID");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topping",
                table: "Topping",
                column: "EntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "EntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crust",
                table: "Crust",
                column: "EntityID");

            migrationBuilder.CreateTable(
                name: "APizzaTopping",
                columns: table => new
                {
                    PizzasEntityID = table.Column<long>(type: "bigint", nullable: false),
                    ToppingsEntityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APizzaTopping", x => new { x.PizzasEntityID, x.ToppingsEntityID });
                    table.ForeignKey(
                        name: "FK_APizzaTopping_Pizzas_PizzasEntityID",
                        column: x => x.PizzasEntityID,
                        principalTable: "Pizzas",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_APizzaTopping_Topping_ToppingsEntityID",
                        column: x => x.ToppingsEntityID,
                        principalTable: "Topping",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Crust",
                keyColumn: "EntityID",
                keyValue: 2L,
                columns: new[] { "name", "price" },
                values: new object[] { "Stuffed", 3.0 });

            migrationBuilder.UpdateData(
                table: "Crust",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "name",
                value: "Pretzel");

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 1L,
                columns: new[] { "name", "price" },
                values: new object[] { "Pepperoni", 1.0 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 2L,
                columns: new[] { "name", "price" },
                values: new object[] { "Extra Cheese", 1.0 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 3L,
                columns: new[] { "name", "price" },
                values: new object[] { "Sausage", 1.0 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 4L,
                columns: new[] { "name", "price" },
                values: new object[] { "Ham", 1.5 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 5L,
                columns: new[] { "name", "price" },
                values: new object[] { "Bacon", 1.5 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 6L,
                columns: new[] { "name", "price" },
                values: new object[] { "Chicken", 1.5 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 7L,
                columns: new[] { "name", "price" },
                values: new object[] { "Buffalo Chicken", 1.5 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 8L,
                column: "name",
                value: "Tomato");

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 9L,
                column: "name",
                value: "Onion");

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 10L,
                column: "name",
                value: "Olives");

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 11L,
                column: "name",
                value: "Mushroom");

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 12L,
                column: "name",
                value: "Spinach");

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 13L,
                column: "name",
                value: "Peppers");

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 14L,
                columns: new[] { "name", "price" },
                values: new object[] { "Shrimp", 2.0 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 15L,
                columns: new[] { "name", "price" },
                values: new object[] { "Garlic", 0.5 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 16L,
                columns: new[] { "name", "price" },
                values: new object[] { "BBQ Sauce", 0.5 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 17L,
                columns: new[] { "name", "price" },
                values: new object[] { "Scallions", 1.0 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 18L,
                columns: new[] { "name", "price" },
                values: new object[] { "Scallops", 2.0 });

            migrationBuilder.UpdateData(
                table: "Topping",
                keyColumn: "EntityID",
                keyValue: 19L,
                column: "name",
                value: "Pineapple");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityID2",
                table: "Pizzas",
                column: "CrustEntityID2");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderEntityID",
                table: "Pizzas",
                column: "OrderEntityID");

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

            migrationBuilder.CreateIndex(
                name: "IX_APizzaTopping_ToppingsEntityID",
                table: "APizzaTopping",
                column: "ToppingsEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_CustomerEntityID",
                table: "Order",
                column: "CustomerEntityID",
                principalTable: "Customers",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Order_Pizzas_PizzaEntityID",
                table: "Order",
                column: "PizzaEntityID",
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
                name: "FK_Order_Stores_StoreEntityID",
                table: "Order",
                column: "StoreEntityID",
                principalTable: "Stores",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crust_CrustEntityID",
                table: "Pizzas",
                column: "CrustEntityID",
                principalTable: "Crust",
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
    }
}
