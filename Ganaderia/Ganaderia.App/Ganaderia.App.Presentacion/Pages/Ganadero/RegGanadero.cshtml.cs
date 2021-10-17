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
    public class RegGanaderoModel : PageModel
    {
        //creamos variable de tipo IRepositorioGanadero
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext());

        public void OnGet()
        {
        }

        public void OnPostAdd(Ganadero ganadero)
        {
            //guardamos el ganadero en la BD
            _repositorioGanadero.AddGanadero(ganadero);
        }
    }
}
