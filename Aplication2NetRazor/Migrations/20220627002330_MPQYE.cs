using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplication2NetRazor.Migrations
{
    public partial class MPQYE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Profesor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Curso",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Profesor");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Curso");
        }
    }
}
