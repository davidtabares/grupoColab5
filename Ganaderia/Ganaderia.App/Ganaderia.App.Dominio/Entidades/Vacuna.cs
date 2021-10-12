using System;
namespace Ganaderia.App.Dominio
{
    public class Vacuna
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Dosis { get; set; }
        public string ViaAdministracion { get; set; }
        public string CicloVacunacion { get; set; }
        public string Lote { get; set; }
        public string Laboratorio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public float Valor { get; set; }
    }
}