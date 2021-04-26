using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class code_fixer__dataDrop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.CreateTable(
                name: "Crust",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crust", x => x.EntityID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.EntityID);
                });

            migrationBuilder.CreateTable(
                name: "Topping",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topping", x => x.EntityID);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrustEntityID = table.Column<long>(type: "bigint", nullable: true),
                    SizeEntityID = table.Column<long>(type: "bigint", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.EntityID);
                    table.ForeignKey(
                        name: "FK_Pizzas_Crust_CrustEntityID",
                        column: x => x.CrustEntityID,
                        principalTable: "Crust",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Sizes_SizeEntityID",
                        column: x => x.SizeEntityID,
                        principalTable: "Sizes",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerEntityID = table.Column<long>(type: "bigint", nullable: true),
                    StoreEntityID = table.Column<long>(type: "bigint", nullable: true),
                    PizzaEntityID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.EntityID);
                    table.ForeignKey(
                        name: "FK_Order_Customers_CustomerEntityID",
                        column: x => x.CustomerEntityID,
                        principalTable: "Customers",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Pizzas_PizzaEntityID",
                        column: x => x.PizzaEntityID,
                        principalTable: "Pizzas",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Stores_StoreEntityID",
                        column: x => x.StoreEntityID,
                        principalTable: "Stores",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "name",
                value: "Timothy Horton");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "EntityID", "name" },
                values: new object[,]
                {
                    { 1L, "Ashley Johnson" },
                    { 2L, "Elizabeth Gainor" },
                    { 4L, "Mario Jumpman Mario" },
                    { 5L, "Doge Coin" }
                });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "name",
                value: "Main St.");

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityID", "Discriminator", "name" },
                values: new object[,]
                {
                    { 2L, "ChicagoStore", "West Rd." },
                    { 3L, "ChicagoStore", "North Ave." },
                    { 4L, "ChicagoStore", "East St." },
                    { 5L, "ChicagoStore", "South Cir." },
                    { 6L, "NewYorkStore", "South James St." },
                    { 7L, "NewYorkStore", "Erie Blvd." },
                    { 8L, "NewYorkStore", "Black River Blvd." },
                    { 9L, "NewYorkStore", "Name_Pending Rd." },
                    { 10L, "NewYorkStore", "Artist Ln." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_APizzaTopping_ToppingsEntityID",
                table: "APizzaTopping",
                column: "ToppingsEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerEntityID",
                table: "Order",
                column: "CustomerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PizzaEntityID",
                table: "Order",
                column: "PizzaEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StoreEntityID",
                table: "Order",
                column: "StoreEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityID",
                table: "Pizzas",
                column: "CrustEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeEntityID",
                table: "Pizzas",
                column: "SizeEntityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APizzaTopping");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Topping");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Crust");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 10L);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "name",
                value: "Ashley Johnson");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "name",
                value: "Main St. PizzaBox");

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityID", "Discriminator", "name" },
                values: new object[] { 2L, "NewYorkStore", "South James St. PizzaBox" });
        }
    }
}
