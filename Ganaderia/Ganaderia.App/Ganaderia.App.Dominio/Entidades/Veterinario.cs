using System.Collections.Generic;

namespace Ganaderia.App.Dominio
{
    public class Veterinario : Persona
    {
        public string Especialidad { get; set; }
        public string TarjetaProfesional { get; set; }

        //Relacion 1 a * entre Veterinario y Ejemplar
        public List<Ejemplar> Ejemplares { get; set;}
    }
}