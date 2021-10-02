namespace Ganaderia.App.Dominio
{
    public class Ejemplar
    {
        public int Id { get; set; }
        public float Edad { get; set; }
        public float Peso { get; set; }
        public Genero Genero { get; set; }
        public string Raza { get; set; }
        public string FechaIngreso { get; set; }
        public string FechaSalida { get; set; }
        public bool SolicitudVeterinario { get; set; }
    }
}