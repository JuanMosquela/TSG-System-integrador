using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Ejercicio2
    {
        public static void Run()
        {
            Console.WriteLine("Ingrese la cantidad de alumnos para ingresar sus notas: ");
            int cantidadAlumnos = Convert.ToInt32(Console.ReadLine());

       
            IngresarNotas(cantidadAlumnos);


        }

        public static void IngresarNotas( int cantidadAlumnos)
        {
            

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Alumno alumno = new Alumno();
                Console.WriteLine("Ingrese las 3 notas del alumno: ");
                for (int j = 0; j < 3; j++)
                {
                    
                    int nota = Convert.ToInt32(Console.ReadLine());
                    alumno.Notas.Add(nota);
                }

                 alumno.CalcularPromedio();

            }

            
        }

       
    }
}
