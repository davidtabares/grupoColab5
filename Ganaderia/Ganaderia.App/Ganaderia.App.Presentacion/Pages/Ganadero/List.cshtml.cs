using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Presentacion.Pages
{
    public class ListModel : PageModel
    {
        public List<Ganadero> Ganaderos { get; set; }//Declaramos estructura List para agregar ganaderos

        public void OnGet()
        {
            var ganadero = new Ganadero //instanciamos objeto ganadero
            {
                Cedula = "14855647",
                Nombres = "Sergio",
                Apellidos = "Moreno",
                NumeroTelefono = "3124568744",
                Email = "sergiomintic@mintic.edu.co",
                Contrasena = "123456",
                Rol = Rol.Ganadero,
                RegistroFedegan = "AD123685447"
            };

            var ganadero1 = new Ganadero
            {
                Cedula = "45988321",
                Nombres = "Susana",
                Apellidos = "Palacio",
                NumeroTelefono = "3104443355",
                Email = "susana@mintic.edu.co",
                Contrasena = "128856",
                Rol = Rol.Ganadero,
                RegistroFedegan = "AD124515447"
            };

            Ganaderos = new List<Ganadero>();//Instanciamos la Lista Ganaderos

            //agregamos ganaderos a la lista
            Ganaderos.Add(ganadero);
            Ganaderos.Add(ganadero1);
        }
    }
}
