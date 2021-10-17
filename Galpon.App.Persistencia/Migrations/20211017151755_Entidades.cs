using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Galpon.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sheds",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total_animals = table.Column<int>(type: "int", nullable: false),
                    admission_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    departure_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sheds", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TypeDocs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDocs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<int>(type: "int", nullable: true),
                    complete_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<int>(type: "int", nullable: false),
                    type_docid = table.Column<int>(type: "int", nullable: true),
                    number_doc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rolid = table.Column<int>(type: "int", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Employers_Roles_rolid",
                        column: x => x.rolid,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employers_TypeDocs_type_docid",
                        column: x => x.type_docid,
                        principalTable: "TypeDocs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employers_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssignedSheds",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shedid = table.Column<int>(type: "int", nullable: true),
                    employerid = table.Column<int>(type: "int", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedSheds", x => x.id);
                    table.ForeignKey(
                        name: "FK_AssignedSheds_Employers_employerid",
                        column: x => x.employerid,
                        principalTable: "Employers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedSheds_Sheds_shedid",
                        column: x => x.shedid,
                        principalTable: "Sheds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historicals",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shedid = table.Column<int>(type: "int", nullable: true),
                    employerid = table.Column<int>(type: "int", nullable: true),
                    temperature = table.Column<int>(type: "int", nullable: false),
                    water = table.Column<int>(type: "int", nullable: false),
                    food = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sick_chickens = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity_eggs = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicals", x => x.id);
                    table.ForeignKey(
                        name: "FK_Historicals_Employers_employerid",
                        column: x => x.employerid,
                        principalTable: "Employers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Historicals_Sheds_shedid",
                        column: x => x.shedid,
                        principalTable: "Sheds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suggestions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shedid = table.Column<int>(type: "int", nullable: true),
                    employerid = table.Column<int>(type: "int", nullable: true),
                    suggestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggestions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Suggestions_Employers_employerid",
                        column: x => x.employerid,
                        principalTable: "Employers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suggestions_Sheds_shedid",
                        column: x => x.shedid,
                        principalTable: "Sheds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignedSheds_employerid",
                table: "AssignedSheds",
                column: "employerid");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedSheds_shedid",
                table: "AssignedSheds",
                column: "shedid");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_rolid",
                table: "Employers",
                column: "rolid");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_type_docid",
                table: "Employers",
                column: "type_docid");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_userid",
                table: "Employers",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_employerid",
                table: "Historicals",
                column: "employerid");

            migrationBuilder.CreateIndex(
                name: "IX_Historicals_shedid",
                table: "Historicals",
                column: "shedid");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestions_employerid",
                table: "Suggestions",
                column: "employerid");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestions_shedid",
                table: "Suggestions",
                column: "shedid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignedSheds");

            migrationBuilder.DropTable(
                name: "Historicals");

            migrationBuilder.DropTable(
                name: "Suggestions");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "Sheds");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TypeDocs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
