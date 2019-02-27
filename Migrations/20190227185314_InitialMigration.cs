using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fifaCoinsBestEver.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productTypes",
                columns: table => new
                {
                    value = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypes", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "userRoleTypes",
                columns: table => new
                {
                    value = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRoleTypes", x => x.value);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    modDate = table.Column<DateTime>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    price = table.Column<long>(nullable: false),
                    quantity = table.Column<long>(nullable: false),
                    productTypevalue = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                    table.ForeignKey(
                        name: "FK_products_productTypes_productTypevalue",
                        column: x => x.productTypevalue,
                        principalTable: "productTypes",
                        principalColumn: "value",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    modDate = table.Column<DateTime>(nullable: true),
                    username = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    pwd = table.Column<string>(nullable: true),
                    typevalue = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_userRoleTypes_typevalue",
                        column: x => x.typevalue,
                        principalTable: "userRoleTypes",
                        principalColumn: "value",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    modDate = table.Column<DateTime>(nullable: true),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    dateOfBirth = table.Column<string>(nullable: true),
                    userId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                    table.ForeignKey(
                        name: "FK_customers_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transations",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    modDate = table.Column<DateTime>(nullable: true),
                    customerid = table.Column<long>(nullable: true),
                    isPaid = table.Column<bool>(nullable: false),
                    from = table.Column<DateTime>(nullable: true),
                    to = table.Column<DateTime>(nullable: true),
                    productId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transations", x => x.id);
                    table.ForeignKey(
                        name: "FK_transations_customers_customerid",
                        column: x => x.customerid,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_transations_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_userId",
                table: "customers",
                column: "userId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_productTypevalue",
                table: "products",
                column: "productTypevalue");

            migrationBuilder.CreateIndex(
                name: "IX_transations_customerid",
                table: "transations",
                column: "customerid");

            migrationBuilder.CreateIndex(
                name: "IX_transations_productId",
                table: "transations",
                column: "productId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_typevalue",
                table: "users",
                column: "typevalue");



            migrationBuilder.Sql("INSERT INTO userRoleTypes (name) VALUES('normal_user')");
            migrationBuilder.Sql("INSERT INTO userRoleTypes (name) VALUES('admin')");
            migrationBuilder.Sql("INSERT INTO productTypes (name) VALUES('coins')");
            migrationBuilder.Sql("INSERT INTO productTypes (name) VALUES('bot')");
            migrationBuilder.Sql("INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'bot_trial', 0, 1, 2)");
            migrationBuilder.Sql("INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'bot_1w', 10, 7, 2)");
            migrationBuilder.Sql("INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'bot_1m', 20, 30, 2)");
            migrationBuilder.Sql("INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'bot_1y', 100, 365, 2)");
            migrationBuilder.Sql("INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'coins_100k', 100, 100, 1)");
            migrationBuilder.Sql("INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'coins_1m', 1000, 1000, 1)");
            migrationBuilder.Sql("INSERT INTO products (modDate, name, price, quantity, productTypevalue) VALUES(CURDATE(), 'coins_10m', 10000, 10000, 1)");
            migrationBuilder.Sql("INSERT INTO users (modDate, username, email, pwd, typeValue) VALUES(CURDATE(), 'marcinSrarcin', 'testowy@email.com', 'r1bdp8Xh7wMm8Txmjvde/Tw1f3l/ThciQw29ewzSL9WEP62H3jgAexY2uI7t9E5G8oRV8MWxSQ4yIfRtHJMRSA==', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transations");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "productTypes");

            migrationBuilder.DropTable(
                name: "userRoleTypes");
        }
    }
}
