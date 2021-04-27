using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class initial_migrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crusts",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crusts", x => x.EntityID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.EntityID);
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
                name: "Stores",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.EntityID);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrustEntityID = table.Column<long>(type: "bigint", nullable: true),
                    SizeEntityID = table.Column<long>(type: "bigint", nullable: true),
                    CrustEntityID1 = table.Column<long>(type: "bigint", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeEntityID1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.EntityID);
                    table.ForeignKey(
                        name: "FK_Pizzas_Crusts_CrustEntityID",
                        column: x => x.CrustEntityID,
                        principalTable: "Crusts",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Crusts_CrustEntityID1",
                        column: x => x.CrustEntityID1,
                        principalTable: "Crusts",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Sizes_SizeEntityID",
                        column: x => x.SizeEntityID,
                        principalTable: "Sizes",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Sizes_SizeEntityID1",
                        column: x => x.SizeEntityID1,
                        principalTable: "Sizes",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
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
                    table.PrimaryKey("PK_Orders", x => x.EntityID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerEntityID",
                        column: x => x.CustomerEntityID,
                        principalTable: "Customers",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Pizzas_PizzaEntityID",
                        column: x => x.PizzaEntityID,
                        principalTable: "Pizzas",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreEntityID",
                        column: x => x.StoreEntityID,
                        principalTable: "Stores",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APizzaEntityID = table.Column<long>(type: "bigint", nullable: true),
                    APizzaEntityID1 = table.Column<long>(type: "bigint", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.EntityID);
                    table.ForeignKey(
                        name: "FK_Toppings_Pizzas_APizzaEntityID",
                        column: x => x.APizzaEntityID,
                        principalTable: "Pizzas",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Toppings_Pizzas_APizzaEntityID1",
                        column: x => x.APizzaEntityID1,
                        principalTable: "Pizzas",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Crusts",
                columns: new[] { "EntityID", "name", "price" },
                values: new object[,]
                {
                    { 4L, "Deep Dish", 2.0 },
                    { 1L, "Original", 0.0 },
                    { 2L, "Pretzel", 1.5 },
                    { 3L, "Thin", 1.5 },
                    { 6L, "Stuffed", 3.0 },
                    { 5L, "Gluten Free", 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "EntityID", "name" },
                values: new object[,]
                {
                    { 4L, "Mario Jumpman Mario" },
                    { 3L, "Timothy Horton" },
                    { 2L, "Elizabeth Gainor" },
                    { 7L, "Slope Flinton" },
                    { 1L, "Ashley Johnson" },
                    { 8L, "Just Monika" },
                    { 9L, "Plague Doctor" },
                    { 10L, "Darth Plagueis" },
                    { 5L, "Doge Coin" },
                    { 6L, "Ronald Rump" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "EntityID", "CustomerEntityID", "PizzaEntityID", "StoreEntityID" },
                values: new object[,]
                {
                    { 1L, null, null, null },
                    { 2L, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "EntityID", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Small", 10.0 },
                    { 2L, "Medium", 13.0 },
                    { 3L, "Large", 15.0 },
                    { 4L, "XL", 20.0 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityID", "Discriminator", "name" },
                values: new object[,]
                {
                    { 10L, "NewYorkStore", "Artist Ln." },
                    { 9L, "NewYorkStore", "Name_Pending Rd." },
                    { 1L, "ChicagoStore", "Main St." },
                    { 7L, "NewYorkStore", "Erie Blvd." },
                    { 6L, "NewYorkStore", "South James St." },
                    { 8L, "NewYorkStore", "Black River Blvd." },
                    { 5L, "ChicagoStore", "South Cir." },
                    { 4L, "ChicagoStore", "East St." },
                    { 3L, "ChicagoStore", "North Ave." },
                    { 2L, "ChicagoStore", "West Rd." }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "EntityID", "APizzaEntityID", "APizzaEntityID1", "name", "price" },
                values: new object[,]
                {
                    { 14L, null, null, "Scallions", 1.0 },
                    { 15L, null, null, "Spinach", 1.0 },
                    { 16L, null, null, "Tomato", 1.0 },
                    { 19L, null, null, "Chicken", 1.5 },
                    { 18L, null, null, "Bacon", 1.5 },
                    { 13L, null, null, "Sausage", 1.0 },
                    { 20L, null, null, "Ham", 1.5 },
                    { 21L, null, null, "Pineapple", 1.5 },
                    { 17L, null, null, "Anchovies", 1.5 },
                    { 12L, null, null, "Peppers", 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "EntityID", "APizzaEntityID", "APizzaEntityID1", "name", "price" },
                values: new object[,]
                {
                    { 8L, null, null, "Mushroom", 1.0 },
                    { 10L, null, null, "Onion", 1.0 },
                    { 9L, null, null, "Olives", 1.0 },
                    { 7L, null, null, "Extra Cheese", 1.0 },
                    { 6L, null, null, "Ranch", 0.5 },
                    { 5L, null, null, "Garlic", 0.5 },
                    { 4L, null, null, "Buffalo Sauce", 0.5 },
                    { 3L, null, null, "BBQ Sauce", 0.5 },
                    { 2L, null, null, "Pizza Sauce", 0.0 },
                    { 1L, null, null, "Mozzerella", 0.0 },
                    { 22L, null, null, "Scallops", 2.0 },
                    { 11L, null, null, "Pepperoni", 1.0 },
                    { 23L, null, null, "Shrimp", 2.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerEntityID",
                table: "Orders",
                column: "CustomerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PizzaEntityID",
                table: "Orders",
                column: "PizzaEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreEntityID",
                table: "Orders",
                column: "StoreEntityID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_APizzaEntityID",
                table: "Toppings",
                column: "APizzaEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_APizzaEntityID1",
                table: "Toppings",
                column: "APizzaEntityID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Crusts");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
