// <auto-generated />
using System;
using Ganaderia.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ganaderia.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211011233258_Tercera")]
    partial class Tercera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Ganaderia.App.Dominio.Ejemplar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("Edad")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSalida")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FincaId")
                        .HasColumnType("int");

                    b.Property<int?>("GanaderoId")
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int?>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RegistroVacunaId")
                        .HasColumnType("int");

                    b.Property<bool>("SolicitudVeterinario")
                        .HasColumnType("bit");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FincaId");

                    b.HasIndex("GanaderoId");

                    b.HasIndex("HistoriaClinicaId");

                    b.HasIndex("RegistroVacunaId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Ejemplares");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Finca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("Altitud")
                        .HasColumnType("real");

                    b.Property<float>("Area")
                        .HasColumnType("real");

                    b.Property<string>("Clima")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GanaderoId")
                        .HasColumnType("int");

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitud")
                        .HasColumnType("real");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreFinca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombrePropietario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pastos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vereda")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GanaderoId");

                    b.ToTable("Fincas");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CondicionCorporal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Constitucion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoHidratacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("FrecuenciaCardiaca")
                        .HasColumnType("real");

                    b.Property<float>("FrecuenciaRespiratoria")
                        .HasColumnType("real");

                    b.Property<string>("ImpresionDiagnostica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListaProblemas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mucosas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusculoEsqueletico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NodulosLinfaticos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SistemaNervioso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Temperatura")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("HistoriasClinicas");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.RegistroVacuna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CedulaVacunador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaVacunacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraVacunacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreVacunador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RegistroVacunas");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Tratamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.Property<string>("PlanDiagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanTerapeutico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaClinicaId");

                    b.ToTable("Tratamientos");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Vacuna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CicloVacunacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Dosis")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Laboratorio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RegistroVacunaId")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.Property<string>("ViaAdministracion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegistroVacunaId");

                    b.ToTable("Vacunas");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Ganadero", b =>
                {
                    b.HasBaseType("Ganaderia.App.Dominio.Persona");

                    b.Property<string>("RegistroFedegan")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Ganadero");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("Ganaderia.App.Dominio.Persona");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Ejemplar", b =>
                {
                    b.HasOne("Ganaderia.App.Dominio.Finca", null)
                        .WithMany("Ejemplares")
                        .HasForeignKey("FincaId");

                    b.HasOne("Ganaderia.App.Dominio.Ganadero", null)
                        .WithMany("Ejemplares")
                        .HasForeignKey("GanaderoId");

                    b.HasOne("Ganaderia.App.Dominio.HistoriaClinica", "HistoriaClinica")
                        .WithMany()
                        .HasForeignKey("HistoriaClinicaId");

                    b.HasOne("Ganaderia.App.Dominio.RegistroVacuna", "RegistroVacuna")
                        .WithMany()
                        .HasForeignKey("RegistroVacunaId");

                    b.HasOne("Ganaderia.App.Dominio.Veterinario", null)
                        .WithMany("Ejemplares")
                        .HasForeignKey("VeterinarioId");

                    b.Navigation("HistoriaClinica");

                    b.Navigation("RegistroVacuna");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Finca", b =>
                {
                    b.HasOne("Ganaderia.App.Dominio.Ganadero", null)
                        .WithMany("Fincas")
                        .HasForeignKey("GanaderoId");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Tratamiento", b =>
                {
                    b.HasOne("Ganaderia.App.Dominio.HistoriaClinica", null)
                        .WithMany("Tratamientos")
                        .HasForeignKey("HistoriaClinicaId");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Vacuna", b =>
                {
                    b.HasOne("Ganaderia.App.Dominio.RegistroVacuna", null)
                        .WithMany("Vacunas")
                        .HasForeignKey("RegistroVacunaId");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Finca", b =>
                {
                    b.Navigation("Ejemplares");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.HistoriaClinica", b =>
                {
                    b.Navigation("Tratamientos");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.RegistroVacuna", b =>
                {
                    b.Navigation("Vacunas");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Ganadero", b =>
                {
                    b.Navigation("Ejemplares");

                    b.Navigation("Fincas");
                });

            modelBuilder.Entity("Ganaderia.App.Dominio.Veterinario", b =>
                {
                    b.Navigation("Ejemplares");
                });
#pragma warning restore 612, 618
        }
    }
}
