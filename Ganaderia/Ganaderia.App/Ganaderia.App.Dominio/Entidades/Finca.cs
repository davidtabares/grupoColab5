namespace Ganaderia.App.Dominio
{
    public class Finca
    {
        public int Id { get; set; }
        public string NombrePropietario { get; set; }
        public string NombreFinca { get; set; }
        public string Vereda { get; set; }
        public string Municipio { get; set; }
        public string Departamento { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public float Altitud { get; set; }
        public float Area { get; set; }
        public string Clima { get; set; }
        public string Pastos { get; set; }
    }
}