using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgWeb.Domain.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLocationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Localizacao",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Localizacao",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Localizacao",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Localizacao");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Localizacao");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Localizacao");
        }
    }
}
