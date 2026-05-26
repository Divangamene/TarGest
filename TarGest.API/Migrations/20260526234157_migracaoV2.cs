using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarGest.API.Migrations
{
    /// <inheritdoc />
    public partial class migracaoV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tarefaTitulo",
                table: "Tarefas",
                newName: "tituloTarefa");

            migrationBuilder.RenameColumn(
                name: "tarefaDescricao",
                table: "Tarefas",
                newName: "descricaoTarefa");

            migrationBuilder.RenameColumn(
                name: "horaInicio",
                table: "Tarefas",
                newName: "horaInicioTarefa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tituloTarefa",
                table: "Tarefas",
                newName: "tarefaTitulo");

            migrationBuilder.RenameColumn(
                name: "horaInicioTarefa",
                table: "Tarefas",
                newName: "horaInicio");

            migrationBuilder.RenameColumn(
                name: "descricaoTarefa",
                table: "Tarefas",
                newName: "tarefaDescricao");
        }
    }
}
