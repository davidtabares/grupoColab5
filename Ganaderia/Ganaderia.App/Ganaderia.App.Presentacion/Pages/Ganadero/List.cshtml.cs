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
    public class ListModel : PageModel
    {
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext());
        public IEnumerable<Ganadero> Ganaderos { get; set; }

        public void OnGet()
        {
            Ganaderos = _repositorioGanadero.GetAllGanaderos();
        }

        public void OnPostDelete(int id)
        {
            if (id != null)
            {
                _repositorioGanadero.DeleteGanadero(id);//Eliminamos el ganadero
            }
            //Despues de eliminar ganadero recargamos la tabla nuevamente
            Ganaderos = _repositorioGanadero.GetAllGanaderos();
        }
    }
}
