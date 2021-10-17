using System;
using System.Collections.Generic;
using System.Linq;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioGanadero : IRepositorioGanadero
    {
        private readonly AppContext _appContext; //creamos objeto de tipo AppContext

        //constructor de la clase
        public RepositorioGanadero(AppContext appContext)
        {
            _appContext = appContext;
        }

        /*=============================================================================
        METODO AGREGAR GANADERO
        =============================================================================*/
        void IRepositorioGanadero.AddGanadero(Ganadero ganadero)
        {
            _appContext.Ganaderos.Add(ganadero); //agregamos un ganadero
            _appContext.SaveChanges(); //guardamos los cambios
        }

        /*=============================================================================
        METODO ACTUALIZAR GANADERO
        =============================================================================*/
        /*Ganadero IRepositorioGanadero.UpdateGanadero(Ganadero ganadero)
        {
            var ganaderoEncontrado = _appContext.Ganaderos.FirstOrDefault(g => g.Id == ganadero.Id);

            if (ganaderoEncontrado != null){
                ganaderoEncontrado = ganadero;
                _appContext.SaveChanges(); //guardamos los cambios
            }
            return ganaderoEncontrado;
        }*/

        /*=============================================================================
        METODO BORRAR GANADERO
        =============================================================================*/
        void IRepositorioGanadero.DeleteGanadero(int idGanadero)
        {
            var ganaderoEncontrado = _appContext.Ganaderos.FirstOrDefault(g => g.Id == idGanadero);

            if (ganaderoEncontrado != null){
                _appContext.Ganaderos.Remove(ganaderoEncontrado); //Borra el ganadero
            }

            _appContext.SaveChanges(); //guardamos los cambios
        }

        /*=============================================================================
        METODO OBTENER GANADEROS (LISTAR GANADEROS)
        =============================================================================*/
        IEnumerable<Ganadero> IRepositorioGanadero.GetAllGanaderos()
        {
            return _appContext.Ganaderos;
        }



    }
}