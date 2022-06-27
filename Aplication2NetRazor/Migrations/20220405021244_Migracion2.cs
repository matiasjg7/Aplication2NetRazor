using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplication2NetRazor.Migrations
{
    public partial class Migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    IdAlumno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreAlumno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApellidoAlumno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fecha_ing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora_ing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_eg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_nac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cant_cursos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.IdAlumno);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    idProfesor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProfesor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApellidoProfesor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fecha_nac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_ing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.idProfesor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Profesor");
        }
    }
}
