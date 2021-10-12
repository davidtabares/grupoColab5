using System.Collections.Generic;

namespace Ganaderia.App.Dominio
{
    public class Ganadero : Persona
    {
        public string RegistroFedegan { get; set; }

        //Relacion 1 a * entre Ganadero y Finca
        public List<Finca> Fincas {get; set;}
        //Relacion 1 a * entre Ganadero y Ejemplar
        public List<Ejemplar> Ejemplares { get; set;}
    }
}