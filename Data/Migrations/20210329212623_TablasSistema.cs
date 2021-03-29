using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Finder.Data.Migrations
{
    public partial class TablasSistema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Edades",
                columns: table => new
                {
                    IdEdad = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edades", x => x.IdEdad);
                });

            migrationBuilder.CreateTable(
                name: "Especies",
                columns: table => new
                {
                    IdEspecie = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especies", x => x.IdEspecie);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.IdEstado);
                });

            migrationBuilder.CreateTable(
                name: "Portes",
                columns: table => new
                {
                    IdPorte = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portes", x => x.IdPorte);
                });

            migrationBuilder.CreateTable(
                name: "Razas",
                columns: table => new
                {
                    IdRaza = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Razas", x => x.IdRaza);
                });

            migrationBuilder.CreateTable(
                name: "Zonas",
                columns: table => new
                {
                    IdZona = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zonas", x => x.IdZona);
                });

            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IdUsuarioId = table.Column<string>(type: "TEXT", nullable: true),
                    IdEstado1 = table.Column<int>(type: "INTEGER", nullable: true),
                    IdRaza1 = table.Column<int>(type: "INTEGER", nullable: true),
                    IdEspecie1 = table.Column<int>(type: "INTEGER", nullable: true),
                    IdEdad1 = table.Column<int>(type: "INTEGER", nullable: true),
                    IdPorte1 = table.Column<int>(type: "INTEGER", nullable: true),
                    IdZona1 = table.Column<int>(type: "INTEGER", nullable: true),
                    PublicacionId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publicaciones_AspNetUsers_IdUsuarioId",
                        column: x => x.IdUsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Edades_IdEdad1",
                        column: x => x.IdEdad1,
                        principalTable: "Edades",
                        principalColumn: "IdEdad",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Especies_IdEspecie1",
                        column: x => x.IdEspecie1,
                        principalTable: "Especies",
                        principalColumn: "IdEspecie",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Estados_IdEstado1",
                        column: x => x.IdEstado1,
                        principalTable: "Estados",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Portes_IdPorte1",
                        column: x => x.IdPorte1,
                        principalTable: "Portes",
                        principalColumn: "IdPorte",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Publicaciones_PublicacionId",
                        column: x => x.PublicacionId,
                        principalTable: "Publicaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Razas_IdRaza1",
                        column: x => x.IdRaza1,
                        principalTable: "Razas",
                        principalColumn: "IdRaza",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Zonas_IdZona1",
                        column: x => x.IdZona1,
                        principalTable: "Zonas",
                        principalColumn: "IdZona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_IdEdad1",
                table: "Publicaciones",
                column: "IdEdad1");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_IdEspecie1",
                table: "Publicaciones",
                column: "IdEspecie1");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_IdEstado1",
                table: "Publicaciones",
                column: "IdEstado1");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_IdPorte1",
                table: "Publicaciones",
                column: "IdPorte1");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_IdRaza1",
                table: "Publicaciones",
                column: "IdRaza1");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_IdUsuarioId",
                table: "Publicaciones",
                column: "IdUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_IdZona1",
                table: "Publicaciones",
                column: "IdZona1");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_PublicacionId",
                table: "Publicaciones",
                column: "PublicacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publicaciones");

            migrationBuilder.DropTable(
                name: "Edades");

            migrationBuilder.DropTable(
                name: "Especies");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Portes");

            migrationBuilder.DropTable(
                name: "Razas");

            migrationBuilder.DropTable(
                name: "Zonas");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "AspNetUsers");
        }
    }
}
