using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarGest.API.Migrations
{
    /// <inheritdoc />
    public partial class InicialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    tarefaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tarefaTitulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tarefaDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estadoTarefa = table.Column<int>(type: "int", nullable: false),
                    prazoTarefa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaInicio = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.tarefaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");
        }
    }
}
