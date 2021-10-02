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
        public List<Ganadero> Ganaderos { get; set;}

        public void OnGet()
        {
            var ganadero = new Ganadero
            {
                Cedula = "14855647",
                Nombres = "Sergio",
                Apellidos = "Moreno",
                NumeroTelefono = "3124568744",
                Email = "sergiomintic@mintic.edu.co",
                Contrasena = "123456",
                Rol = Rol.ganadero,
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
                Rol = Rol.ganadero,
                RegistroFedegan = "AD124515447"
            };

            Ganaderos = new List<Ganadero>();

            Ganaderos.Add(ganadero);
            Ganaderos.Add(ganadero1);
        }
    }
}
