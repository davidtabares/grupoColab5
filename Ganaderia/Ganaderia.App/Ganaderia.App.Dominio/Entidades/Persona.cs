namespace Ganaderia.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroTelefono { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public Rol Rol { get; set; }
    }
}