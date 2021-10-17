using Ganaderia.App.Dominio;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanadero
    {
        void AddGanadero(Ganadero ganadero);

        //Ganadero UpdateGanadero(Ganadero ganadero);

        void DeleteGanadero(int idGanadero);

        IEnumerable<Ganadero> GetAllGanaderos();//Retorna un IEnumerable que es una coleccion de objetos "Ganadero"

    }

}