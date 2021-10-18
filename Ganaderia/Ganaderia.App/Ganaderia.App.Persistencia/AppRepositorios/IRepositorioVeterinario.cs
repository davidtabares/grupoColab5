using Ganaderia.App.Dominio;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        void AddVeterinario(Veterinario veterinario);

        //Veterinario UpdateVeterinario(Veterinario veterinarioActualizado);

        void DeleteVeterinario(int idVeterinario);

        IEnumerable<Veterinario> GetAllVeterinarios();//Retorna un IEnumerable que es una coleccion de objetos "Veterinario"
    }
}