using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EjemploASPNETMVCCF.Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Curso_Asignatura_AsignaturaId",
                table: "Curso");

            migrationBuilder.DropIndex(
                name: "IX_Curso_AsignaturaId",
                table: "Curso");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Persona",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Persona");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_AsignaturaId",
                table: "Curso",
                column: "AsignaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Curso_Asignatura_AsignaturaId",
                table: "Curso",
                column: "AsignaturaId",
                principalTable: "Asignatura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
