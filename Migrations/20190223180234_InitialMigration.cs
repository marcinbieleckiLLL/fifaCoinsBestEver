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
                name: "UserRoleType",
                columns: table => new
                {
                    Value = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleType", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(nullable: true),
                    pwd = table.Column<string>(nullable: true),
                    modDate = table.Column<DateTime>(nullable: true),
                    typeValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_users_UserRoleType_typeValue",
                        column: x => x.typeValue,
                        principalTable: "UserRoleType",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_typeValue",
                table: "users",
                column: "typeValue");
            
            
            migrationBuilder.Sql("INSERT INTO UserRoleType (Name) VALUES('normal_user')");
            migrationBuilder.Sql("INSERT INTO UserRoleType (Name) VALUES('admin')");
            migrationBuilder.Sql("INSERT INTO users (username, pwd, modDate, typeValue) VALUES('marcinSrarcin', 'Kuba987!@#', CURDATE(), 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "UserRoleType");
        }
    }
}
