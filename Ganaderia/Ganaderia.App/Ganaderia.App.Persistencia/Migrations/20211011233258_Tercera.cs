using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ganaderia.App.Persistencia.Migrations
{
    public partial class Tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaVencimiento",
                table: "Vacunas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegistroVacunaId",
                table: "Vacunas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha",
                table: "Tratamientos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistoriaClinicaId",
                table: "Tratamientos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HoraVacunacion",
                table: "RegistroVacunas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaVacunacion",
                table: "RegistroVacunas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GanaderoId",
                table: "Fincas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaSalida",
                table: "Ejemplares",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaIngreso",
                table: "Ejemplares",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FincaId",
                table: "Ejemplares",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GanaderoId",
                table: "Ejemplares",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistoriaClinicaId",
                table: "Ejemplares",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegistroVacunaId",
                table: "Ejemplares",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeterinarioId",
                table: "Ejemplares",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacunas_RegistroVacunaId",
                table: "Vacunas",
                column: "RegistroVacunaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tratamientos_HistoriaClinicaId",
                table: "Tratamientos",
                column: "HistoriaClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fincas_GanaderoId",
                table: "Fincas",
                column: "GanaderoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplares_FincaId",
                table: "Ejemplares",
                column: "FincaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplares_GanaderoId",
                table: "Ejemplares",
                column: "GanaderoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplares_HistoriaClinicaId",
                table: "Ejemplares",
                column: "HistoriaClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplares_RegistroVacunaId",
                table: "Ejemplares",
                column: "RegistroVacunaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ejemplares_VeterinarioId",
                table: "Ejemplares",
                column: "VeterinarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ejemplares_Fincas_FincaId",
                table: "Ejemplares",
                column: "FincaId",
                principalTable: "Fincas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ejemplares_HistoriasClinicas_HistoriaClinicaId",
                table: "Ejemplares",
                column: "HistoriaClinicaId",
                principalTable: "HistoriasClinicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ejemplares_Personas_GanaderoId",
                table: "Ejemplares",
                column: "GanaderoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ejemplares_Personas_VeterinarioId",
                table: "Ejemplares",
                column: "VeterinarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ejemplares_RegistroVacunas_RegistroVacunaId",
                table: "Ejemplares",
                column: "RegistroVacunaId",
                principalTable: "RegistroVacunas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fincas_Personas_GanaderoId",
                table: "Fincas",
                column: "GanaderoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tratamientos_HistoriasClinicas_HistoriaClinicaId",
                table: "Tratamientos",
                column: "HistoriaClinicaId",
                principalTable: "HistoriasClinicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacunas_RegistroVacunas_RegistroVacunaId",
                table: "Vacunas",
                column: "RegistroVacunaId",
                principalTable: "RegistroVacunas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ejemplares_Fincas_FincaId",
                table: "Ejemplares");

            migrationBuilder.DropForeignKey(
                name: "FK_Ejemplares_HistoriasClinicas_HistoriaClinicaId",
                table: "Ejemplares");

            migrationBuilder.DropForeignKey(
                name: "FK_Ejemplares_Personas_GanaderoId",
                table: "Ejemplares");

            migrationBuilder.DropForeignKey(
                name: "FK_Ejemplares_Personas_VeterinarioId",
                table: "Ejemplares");

            migrationBuilder.DropForeignKey(
                name: "FK_Ejemplares_RegistroVacunas_RegistroVacunaId",
                table: "Ejemplares");

            migrationBuilder.DropForeignKey(
                name: "FK_Fincas_Personas_GanaderoId",
                table: "Fincas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tratamientos_HistoriasClinicas_HistoriaClinicaId",
                table: "Tratamientos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacunas_RegistroVacunas_RegistroVacunaId",
                table: "Vacunas");

            migrationBuilder.DropIndex(
                name: "IX_Vacunas_RegistroVacunaId",
                table: "Vacunas");

            migrationBuilder.DropIndex(
                name: "IX_Tratamientos_HistoriaClinicaId",
                table: "Tratamientos");

            migrationBuilder.DropIndex(
                name: "IX_Fincas_GanaderoId",
                table: "Fincas");

            migrationBuilder.DropIndex(
                name: "IX_Ejemplares_FincaId",
                table: "Ejemplares");

            migrationBuilder.DropIndex(
                name: "IX_Ejemplares_GanaderoId",
                table: "Ejemplares");

            migrationBuilder.DropIndex(
                name: "IX_Ejemplares_HistoriaClinicaId",
                table: "Ejemplares");

            migrationBuilder.DropIndex(
                name: "IX_Ejemplares_RegistroVacunaId",
                table: "Ejemplares");

            migrationBuilder.DropIndex(
                name: "IX_Ejemplares_VeterinarioId",
                table: "Ejemplares");

            migrationBuilder.DropColumn(
                name: "RegistroVacunaId",
                table: "Vacunas");

            migrationBuilder.DropColumn(
                name: "HistoriaClinicaId",
                table: "Tratamientos");

            migrationBuilder.DropColumn(
                name: "GanaderoId",
                table: "Fincas");

            migrationBuilder.DropColumn(
                name: "FincaId",
                table: "Ejemplares");

            migrationBuilder.DropColumn(
                name: "GanaderoId",
                table: "Ejemplares");

            migrationBuilder.DropColumn(
                name: "HistoriaClinicaId",
                table: "Ejemplares");

            migrationBuilder.DropColumn(
                name: "RegistroVacunaId",
                table: "Ejemplares");

            migrationBuilder.DropColumn(
                name: "VeterinarioId",
                table: "Ejemplares");

            migrationBuilder.AlterColumn<string>(
                name: "FechaVencimiento",
                table: "Vacunas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Fecha",
                table: "Tratamientos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "HoraVacunacion",
                table: "RegistroVacunas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "FechaVacunacion",
                table: "RegistroVacunas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "FechaSalida",
                table: "Ejemplares",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "FechaIngreso",
                table: "Ejemplares",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
