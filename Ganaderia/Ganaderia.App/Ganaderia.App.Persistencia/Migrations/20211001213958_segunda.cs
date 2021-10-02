using Microsoft.EntityFrameworkCore.Migrations;

namespace Ganaderia.App.Persistencia.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Personas",
                newName: "TarjetaProfesional");

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Especialidad",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistroFedegan",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rol",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ejemplares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edad = table.Column<float>(type: "real", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIngreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaSalida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolicitudVeterinario = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejemplares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fincas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePropietario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreFinca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vereda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<float>(type: "real", nullable: false),
                    Longitud = table.Column<float>(type: "real", nullable: false),
                    Altitud = table.Column<float>(type: "real", nullable: false),
                    Area = table.Column<float>(type: "real", nullable: false),
                    Clima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pastos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fincas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrecuenciaCardiaca = table.Column<float>(type: "real", nullable: false),
                    FrecuenciaRespiratoria = table.Column<float>(type: "real", nullable: false),
                    Temperatura = table.Column<float>(type: "real", nullable: false),
                    Constitucion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CondicionCorporal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoHidratacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mucosas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NodulosLinfaticos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusculoEsqueletico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SistemaNervioso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListaProblemas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImpresionDiagnostica = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistroVacunas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CedulaVacunador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreVacunador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaVacunacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraVacunacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroVacunas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tratamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanDiagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanTerapeutico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tratamientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacunas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dosis = table.Column<float>(type: "real", nullable: false),
                    ViaAdministracion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CicloVacunacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Laboratorio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaVencimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacunas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ejemplares");

            migrationBuilder.DropTable(
                name: "Fincas");

            migrationBuilder.DropTable(
                name: "HistoriasClinicas");

            migrationBuilder.DropTable(
                name: "RegistroVacunas");

            migrationBuilder.DropTable(
                name: "Tratamientos");

            migrationBuilder.DropTable(
                name: "Vacunas");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Especialidad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "RegistroFedegan",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Rol",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "TarjetaProfesional",
                table: "Personas",
                newName: "Correo");

            migrationBuilder.AddColumn<float>(
                name: "Latitud",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Longitud",
                table: "Personas",
                type: "real",
                nullable: true);
        }
    }
}
