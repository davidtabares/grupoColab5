using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Presentacion.Pages
{
    public class RegVeterinarioModel : PageModel
    {
        //creamos variable de tipo IRepositorioVeterinario
        private static IRepositorioVeterinario _repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        public void OnGet()
        {
        }

        public void OnPostAdd(Veterinario veterinario)
        {
            //guardamos el veterinario en la BD
            _repositorioVeterinario.AddVeterinario(veterinario);
        }
    }
}
