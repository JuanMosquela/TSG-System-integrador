using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Ejercicio1
    {
        public static void Run()
        {


            string nombre = PedirNombre();
            Console.WriteLine($"Bienvenido: {nombre}");

            int edad = PedirEdad();
            Console.WriteLine($"La edad ingresada por el usuario: {nombre} es: {edad}");

            if(edad >= 18)
            {
                Console.WriteLine("Este usuario es mayo de edad");
            }
            else
            {
                Console.WriteLine("Este usuario es meor de edad");
            }

            Pausar();


            string categoria = PedirCategoria();
            

            switch( categoria )
            {
                case "A":
                    Console.WriteLine("El usuario pertence a la categoria Administrativo");
                    break;
                case "B":
                    Console.WriteLine("El usuario pertence a la categoria Gerente");
                    break; 
                case "C":
                    Console.WriteLine("El usuario pertence a la categoria Tecnico");
                    break; 
                case "D":
                    Console.WriteLine("El usuario pertence a la categoria Maestranza");
                    break; 
                
                default: 
                    Console.WriteLine("No tiene una catgoria valida");
                    break;
                    
            }


        }

        public static string PedirNombre()
        {          

            Console.WriteLine("Por favor ingrese su nombre");
            string nombre = Console.ReadLine();

            while (nombre.Trim() == "" )
            {
                Console.WriteLine("Debes ingresar un valor valido");
                nombre = Console.ReadLine();
            }            

            return nombre;
            
            
        }

        public static int PedirEdad()
        {
            int edad = 0;
            while (edad == 0)
            {
                try
                {
                    Console.WriteLine("Ingrese su edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un error, por favor ingrese una edad válida.");
                    Console.WriteLine(e.Message); // Muestra el mensaje de error específico
                }              

            }

            return edad; // Devuelve el valor ingresado o 0 en caso de error

        }

        public static void Pausar()
        {
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadLine();
            
        }

        public static string PedirCategoria()
        {
            Console.WriteLine("Ingrese la categoria");
            string categoria = Console.ReadLine();
            return categoria.ToUpper();




        }
    }
}
