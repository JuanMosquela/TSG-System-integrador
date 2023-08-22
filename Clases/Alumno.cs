using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Alumno
    {
        public  List<int> Notas { get; set; }

        public Alumno()
        {
            Notas = new List<int>();
        }

        public void CalcularPromedio()
        {
            int acc = 0;
            foreach (int nota in Notas)
            {
                acc += nota;

            }
            float resultado = acc / Notas.Count;
            Console.WriteLine($"el promedio de este alumno es : {resultado}");

        }
    }
}
