using System;
using System.Collections.Generic;
using System.Linq;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly AppContext _appContext; //creamos objeto de tipo AppContext

        //constructor de la clase
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        //metodo guardar veterinario
        void IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            _appContext.Veterinarios.Add(veterinario); //agregamos un veterinario
            _appContext.SaveChanges(); //guardamos los cambios
        }


        /*=============================================================================
        METODO BORRAR VETERINARIO
        =============================================================================*/
        void IRepositorioVeterinario.DeleteVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);

            if (veterinarioEncontrado != null){
                _appContext.Veterinarios.Remove(veterinarioEncontrado); //Borra el veterinario
            }

            _appContext.SaveChanges(); //guardamos los cambios
        }

        /*=============================================================================
        METODO OBTENER VETERINARIOS (LISTAR VETERINARIOS)
        =============================================================================*/
        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }
    }
}