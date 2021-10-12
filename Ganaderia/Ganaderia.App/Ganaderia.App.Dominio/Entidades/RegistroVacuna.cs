using System;
using System.Collections.Generic;

namespace Ganaderia.App.Dominio
{
    public class RegistroVacuna
    {
        public int Id { get; set; }
        public string CedulaVacunador { get; set; }
        public string NombreVacunador { get; set; }
        public DateTime FechaVacunacion { get; set; }
        public DateTime HoraVacunacion { get; set; }
        public string Observaciones { get; set; }

        //Relacion 1 a * entre RegistroVacuna y Vacuna
        public List<Vacuna> Vacunas { get; set; }
    }
}