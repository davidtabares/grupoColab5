using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {
        //creamos variable de tipo IRepositorioGanadero
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext());

        //Función main
        //**********************************************************************************
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Entity FrameWork!");
            AddGanadero(); //llamamos al metodo agregar ganadero a la BD
        }

        //**********************************************************************************

        private static void AddGanadero() //Metodo agregar ganadero
        {
            var ganadero = new Ganadero //Instanciamos un ganadero
            {
                Cedula = "123",
                Nombres = "Carlos",
                Apellidos = "Gomez",
                NumeroTelefono = "123",
                Email = "carlos@gmail.com",
                Contrasena = "123",
                Rol = Rol.Ganadero, //dato de tipo enum: Ganadero o Veterinario
                RegistroFedegan = "FD1234"
            };

            _repositorioGanadero.AddGanadero(ganadero); //guardamos el ganadero en la BD

        }
    }
}
