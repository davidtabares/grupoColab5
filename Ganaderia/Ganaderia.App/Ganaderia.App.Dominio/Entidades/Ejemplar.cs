using System;

namespace Ganaderia.App.Dominio
{
    public class Ejemplar
    {
        public int Id { get; set; }
        public float Edad { get; set; }
        public float Peso { get; set; }
        public Genero Genero { get; set; }
        public string Raza { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public bool SolicitudVeterinario { get; set; }

        //Relacion 1 a 1 entre Ejemplar y RegistroVacuna
        public RegistroVacuna RegistroVacuna { get; set; }
        //Relacion 1 a 1 entre Ejemplar e HC
        public HistoriaClinica HistoriaClinica { get; set; }
    }
}