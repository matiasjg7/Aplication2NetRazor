﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplication2NetRazor.Migrations
{
    public partial class KTR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Alumno",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Alumno");
        }
    }
}
