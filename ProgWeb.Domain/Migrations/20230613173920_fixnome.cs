using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgWeb.Domain.Migrations
{
    /// <inheritdoc />
    public partial class fixnome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Execicio",
                table: "AcompanhamentoOrcamentario",
                newName: "Exercicio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Exercicio",
                table: "AcompanhamentoOrcamentario",
                newName: "Execicio");
        }
    }
}
