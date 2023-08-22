using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Ejercicio3
    {
        public static void Run()
        {
            Bienvenida();
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine(BienvenidaPorNombre(nombreUsuario));

     
            ModificarNombrePorReferencia(ref nombreUsuario);
            Console.WriteLine($"Nombre modificado por referencia: {nombreUsuario}");

            Console.WriteLine(CambiarNombre());
            Console.WriteLine(CambiarNombre("Carlos"));
        }

        static void Bienvenida()
        {
            Console.WriteLine("Bienvenidos al curso de .Net.");
        }

        // 2) Método BienvenidaPorNombre
        static string BienvenidaPorNombre(string nombre)
        {
            return $"Bienvenido {nombre}.";
        }

        // 3) Método ModificarNombrePorReferencia
        static void ModificarNombrePorReferencia(ref string nombre)
        {
            Console.WriteLine("Ingrese un nuevo nombre: ");
            nombre = Console.ReadLine();
        }

    
        static string CambiarNombre()
        {
            return "Mi nombre es Tu Nombre.";
        }

     
        static string CambiarNombre(string nombre)
        {
            return $"Mi nombre es {nombre}.";
        }
    }
}
