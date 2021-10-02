namespace Ganaderia.App.Dominio
{
    public class RegistroVacuna
    {
        public int Id { get; set; }
        public string CedulaVacunador { get; set; }
        public string NombreVacunador { get; set; }
        public string FechaVacunacion { get; set; }
        public string HoraVacunacion { get; set; }
        public string Observaciones { get; set; }
    }
}