
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

        //metodo guardar ganadero
        void IRepositorioGanadero.AddGanadero(Ganadero ganadero)
        {
            _appContext.Ganaderos.Add(ganadero); //agregamos un ganadero
            _appContext.SaveChanges(); //guardamos los cambios
        }
    }
}