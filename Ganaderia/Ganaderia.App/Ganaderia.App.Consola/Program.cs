using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {
        //creamos variable de tipo IRepositorioGanadero
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext());

        //creamos variable de tipo IRepositorioVeterinario
        private static IRepositorioVeterinario _repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());


        //Función main
        //**********************************************************************************
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Entity FrameWork!");
            //AddGanadero(); //llamamos al metodo agregar ganadero a la BD
            //AddVeterinario(); //llamamos al metodo agregar veterinario a la BD
            //DeleteGanadero(9); //llamamos al metodo Borrar ganadero de la BD
            UpdateGanadero();
            //GetAllGanaderos(); //llamamos al metodo listar ganaderos
        }

        //**********************************************************************************


        /*=============================================================================
        METODO AGREGAR GANADERO
        =============================================================================*/
        private static void AddGanadero()
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

        /*=============================================================================
        METODO AGREGAR VETERINARIO
        =============================================================================*/
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario //Instanciamos un veterinario
            {
                Cedula = "456",
                Nombres = "Pepe",
                Apellidos = "Sierra",
                NumeroTelefono = "4567",
                Email = "pepe@gmail.com",
                Contrasena = "123",
                Rol = Rol.Veterinario, //dato de tipo enum: Ganadero o Veterinario
                Especialidad = "Inmunología",
                TarjetaProfesional = "TP45654"
            };
            _repositorioVeterinario.AddVeterinario(veterinario); //guardamos el veterinario en la BD
        }

        /*=============================================================================
        METODO BORRAR GANADERO
        =============================================================================*/
        private static void DeleteGanadero(int idGanadero)
        {
            _repositorioGanadero.DeleteGanadero(idGanadero); //Borramos Ganadero
        }

        /*=============================================================================
        METODO ACTUALIZAR GANADERO
        =============================================================================*/
        private static void UpdateGanadero(Ganadero ganadero)
        {
            _repositorioGanadero.UpdateGanadero(ganadero); //Actualizamos Ganadero
        }



        /*=============================================================================
        METODO LISTAR GANADEROS
        =============================================================================*/
        private static void GetAllGanaderos()
        {
            var ganaderos = _repositorioGanadero.GetAllGanaderos();

            foreach (var ganadero in ganaderos)
            {
                Console.WriteLine(ganadero.Nombres + " " + ganadero.Apellidos);
            }
        }
    }
}
