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
    }
}